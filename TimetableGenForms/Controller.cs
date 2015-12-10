using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Rca.TtGen
{
    /// <summary>
    /// Modell
    /// </summary>
    public class Controller : INotifyPropertyChanged
    {
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Letztes Finale zusammen fassen
        /// </summary>
        public bool AddLastFinal { get; set; }

        /// <summary>
        /// Anzahl der verbleibenden Endfinale, der entsprechenden Klassen
        /// </summary>
        public int[] RemainingEndFinals { get; set; }

        /// <summary>
        /// Anzahl wie oft die Endfinale wiederholt werden
        /// </summary>
        public int FinalCount { get; set; }

        public List<Heat> Heats { get; set; }

        /// <summary>
        /// Hält alle zu fahrenenden Runden (Finale, je A UND B) der Klasse ORE8
        /// </summary>
        public List<HeatRound> RoundsOre8 { get; set; }

        /// <summary>
        /// Gesamtgröße der Final-Läufe
        /// </summary>
        public UInt16 GroupSize { get; set; }

        /// <summary>
        /// Fahrer welche in ein Finallauf direkt eingeteilt werden
        /// </summary>
        public UInt16 ScheuduleDrivers
        {
            get
            {
                //PATCH Variable Gruppengrößen
                if (GroupSize == 10)
                    return 7;
                else if (GroupSize == 12)
                    return 8;
                else if (GroupSize == 8)
                    return 5;
                else if (GroupSize == 15)
                    return 10;
                else
                    throw new NotImplementedException("Gruppengröße wird derzeit nicht unterstützt");
            }
        }

        /// <summary>
        /// Aufsteigende Fahrer in den Unterfinalen
        /// </summary>
        public int RisingDrivers
        {
            get
            {
                return GroupSize - ScheuduleDrivers;
            }
        }

        public ClassDuration[] Durations { get; set; }

        /// <summary>
        /// Pausenzeit zwischen Läufen
        /// </summary>
        public TimeSpan ChangeTime { get; set; }

        /// <summary>
        /// Startzeit des ersten Finales
        /// </summary>
        public DateTime StartTime { get; set; }

        public bool AdditionalFinals { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for Controller
        /// </summary>
        public Controller()
        {
            this.Durations = new ClassDuration[Enum.GetValues(typeof(ClassEnum)).Length];

            this.RemainingEndFinals = new int[Enum.GetValues(typeof(ClassEnum)).Length];
        }

        #endregion Constructor

        #region Services

        public bool GenerateFinals(UInt16 or8drv, UInt16 ortdrv, UInt16 ore8drv, UInt16 groupSize = 0)
        {
            this.GroupSize = groupSize;
            Heats = new List<Heat>();

            Queue<Heat> or8Heats = GenerateClassFinals(or8drv, ClassEnum.Or8);
            Queue<Heat> ortHeats = GenerateClassFinals(ortdrv, ClassEnum.Ort);
            Queue<Heat> ore8Heats = GenerateClassFinals(ore8drv, ClassEnum.Ore8);
            Queue<Heat> ore8AdditionalHeats = null;

            if (AdditionalFinals)
            {
                
                GenerateAdditionalFinals(GenerateOre8Rounds(ore8drv), ClassEnum.Ore8);
            }

            while (or8Heats.Count > 0 || ortHeats.Count > 0 || ore8Heats.Count > 0)
            {
                if (FinalCount > 1)
                {
                    ApplyHeat(ore8Heats); //Mit ORE8 beginnen -> ORE8-Finale wird einmal vor und einmal nach den Verbrenner-Finalen gefahren
                    ApplyHeat(or8Heats);
                    ApplyHeat(ortHeats);
                }
                else
                {
                    ApplyHeat(or8Heats);
                    ApplyHeat(ortHeats);
                    ApplyHeat(ore8Heats);
                }
            }


            Heats.Reverse();

            for (int i = 0; i < Heats.Count; i++)
            {
                if (i == 0)
                    Heats[i].StartTime = StartTime;
                else
                {
                    Heats[i].StartTime = Heats[i - 1].EndTime + ChangeTime;

                    //PATCH Wartezeiten berücksichtigen
                }
            }

                return true;
        }

        #endregion Services

        #region Internal services
        /// <summary>
        /// Zusatzfinale erzeugen
        /// </summary>
        /// <param name="heatQueue"></param>
        /// <returns></returns>
        private Queue<Heat> GenerateAdditionalHeats(Queue<Heat> heatQueue)
        {
            Queue<Heat> res = new Queue<Heat>();

            List<Heat> heatList = heatQueue.ToList();

            #region Aufsteiger ermitteln

            int risingDriversA = RisingDrivers;
            int risingDriversB = 0;

            if (heatList[heatList.Count - 1].DriverCount < RisingDrivers)
                risingDriversA = heatList[heatList.Count].DriverCount;

            FinalNameEnum currentFinal = heatList[heatList.Count - 1].Final;
            if (heatList.Count(x => x.Final == currentFinal) > 1)
            {
                if (heatList[heatList.Count - 2].DriverCount < RisingDrivers)
                    risingDriversB = heatList[heatList.Count - 2].DriverCount;
                else
                    risingDriversB = RisingDrivers;
            }

            for (int i = heatList.Count - 2; i > 0 ; i--)
            {
                if (heatList.Count(x => x.Final == currentFinal) > 1)
                {

                }
            }

            #endregion

            Dictionary<FinalNameEnum, int> eliminatetDrivers = new Dictionary<FinalNameEnum, int>();

            foreach (Heat heat in heatList)
            {
                if (heat.Final != FinalNameEnum.Finale && !eliminatetDrivers.ContainsKey(heat.Final))
                {
                    eliminatetDrivers.Add(heat.Final, heatList.Where(x => x.Final == heat.Final).Sum(x => x.RemainingDrivers));
                }
            }





            return res;
        }

        private bool AnyScheuduleEndFinals(ClassEnum excludeClass)
        {
            List<int> remainingEndFinals = RemainingEndFinals.ToList();
            remainingEndFinals[(int)excludeClass]--;

            bool res = remainingEndFinals.Any(x => x > 0);

            return res;
        }

        private Heat DequeueHeat(Queue<Heat> heats)
        {
            if (heats.Count > 0)
            {
                Heat heat = heats.Dequeue();

                if (heat.Final == FinalNameEnum.Finale)
                    RemainingEndFinals[(int)heat.HeatClass]--;

                return heat;
            }
            else
                return null;
        }

        /// <summary>
        /// Fügt einen Final-Lauf der Laufliste (aller Klassen) hinzu
        /// </summary>
        /// <param name="heats"></param>
        private void ApplyHeat(Queue<Heat> heats)
        {
            if (heats.Count > 0 && (!AnyScheuduleEndFinals(heats.Peek().HeatClass) || heats.Peek().Final == FinalNameEnum.Finale)) //TODO Prüfen ob alle Endfinale schon verteilt sind
            {
                Heat currentHeat = DequeueHeat(heats);

                if (currentHeat != null)
                {
                    Heats.Add(currentHeat);

                    if (currentHeat.Final != FinalNameEnum.Finale && heats.Count > 0 && heats.Peek() != null && currentHeat.Final == heats.Peek().Final)
                    {
                        Heats.Add(heats.Dequeue());
                    }
                } 
            }
        }

        /// <summary>
        /// Erzegut die Finale für eine Klasse
        /// </summary>
        /// <param name="drvAmount">Anzahl der Fahrer welche einzuteilen sind</param>
        /// <param name="heatClass">Klasse</param>
        /// <returns>Queue mit den erstellten Finalen</returns>
        private Queue<Heat> GenerateClassFinals(UInt16 drvAmount, ClassEnum heatClass)
        {
            Queue<Heat> res = new Queue<Heat>();

            int remainingDrvCnt = drvAmount;
            int finalCnt = this.FinalCount;

            if (heatClass != ClassEnum.Ore8)    //Mehrere Finale nur bei ORE8
                finalCnt = 1;

            FinalNameEnum currentFinalName = FinalNameEnum.Finale;

            while(remainingDrvCnt > 0)
            {
                List<Heat> currentHeats = new List<Heat>();


                if (currentFinalName == FinalNameEnum.Finale)
                {
                    FinalCharEnum finalChar = FinalCharEnum.OnlyOneFinal;

                    if (finalCnt > 1)
                        finalChar = (FinalCharEnum)Enum.ToObject(typeof(FinalCharEnum), -1 - finalCnt);

                    for (int i = 0; i < finalCnt; i++)    //Mehrere Endfinale erstellen
                    {
                        if (drvAmount <= GroupSize)
                        {
                            //Es gibt nur ein Endfinale

                            currentHeats.Add(new Heat(currentFinalName, finalChar, drvAmount, heatClass));
                            RemainingEndFinals[(int)heatClass]++;
                        }
                        else
                        {
                            //Leeres Finale erstellen

                            currentHeats.Add(new Heat(currentFinalName, finalChar, 0, heatClass));
                            RemainingEndFinals[(int)heatClass]++;
                        }

                        finalChar++;
                    }

                }
                else
                {
                    //PATCH Hier müssen auch die Zusatzfinale erzeugt werden
                    if (remainingDrvCnt > 2 * GroupSize)
                    {
                        //Es müssen zwei volle Finale (A/B) müssen erzeugt werden, Aufsteigerplätze beachten

                        for (int i = 0; i < 2; i++)
                            currentHeats.Add(new Heat(currentFinalName, (FinalCharEnum)Enum.ToObject(typeof(FinalCharEnum), i), ScheuduleDrivers, heatClass));
                    }
                    else if (AddLastFinal && remainingDrvCnt <= GroupSize)
                    {
                        //Letztes Finale, verbleibende Fahrer in einen Finale zusammen fassen

                        currentHeats.Add(new Heat(currentFinalName, FinalCharEnum.OnlyOneFinal, remainingDrvCnt, heatClass));
                    }
                    else
                    {
                        //Letzte Finale, können bis Gruppengröße aufgefüllt werden

                        currentHeats.Add(new Heat(currentFinalName, FinalCharEnum.A, remainingDrvCnt / 2, heatClass));
                        currentHeats.Add(new Heat(currentFinalName, FinalCharEnum.B, remainingDrvCnt - currentHeats.Last().DriverCount, heatClass));
                    } 
                }


                foreach (Heat currentHeat in currentHeats)
                {
                    switch (currentFinalName)
                    {
                        case FinalNameEnum.Finale:
                            currentHeat.Duration = Durations[(int)heatClass].Finals;
                            break;
                        case FinalNameEnum.Finale_1_2:
                            currentHeat.Duration = Durations[(int)heatClass].HalfFinals;
                            break;
                        default:
                            currentHeat.Duration = Durations[(int)heatClass].SubFinals;
                            break;
                    }

                    remainingDrvCnt -= currentHeat.DriverCount;
                    res.Enqueue(currentHeat);
                }


                currentHeats.Clear();

                currentFinalName++;
            }

            return res;
        }

        /// <summary>
        /// Erzeugt Zusatzfinale
        /// </summary>
        /// <param name="rounds"></param>
        /// <returns></returns>
        private Queue<Heat> GenerateAdditionalFinals(List<HeatRound> rounds, ClassEnum heatClass)
        {
            Queue<Heat> heats = new Queue<Heat>();
            FinalCharEnum finChar = FinalCharEnum.A2;
            int rest = 0;
            foreach (HeatRound round in rounds)
            {
                if (rest < 0)
                    rest = 0;
                    
                if ((round.Looser + rest) >= GroupSize)
                {
                    heats.Enqueue(new Heat(FinalNameEnum.Finale, finChar, GroupSize, heatClass, new TimeSpan(0,10,0), true));
                    rest = round.Looser + rest - GroupSize;

                    finChar--;
                }
                else
                {
                    rest = round.Looser + rest;
                }

                
                if (rest >= GroupSize)
                {
                    heats.Enqueue(new Heat(FinalNameEnum.Finale, finChar, GroupSize, heatClass, new TimeSpan(0, 10, 0), true));
                    rest -= GroupSize;

                    finChar--;
                }
            }

            if (rest > 0)
                heats.Enqueue(new Heat(FinalNameEnum.Finale, finChar, rest, heatClass, new TimeSpan(0, 10, 0), true));

            return heats;
        }

        /// <summary>
        /// Erzeugt die zu fahrenden Runden
        /// </summary>
        /// <param name="totalDrivers">Anzahl der Starter</param>
        private List<HeatRound> GenerateOre8Rounds(int totalDrivers)
        {
            List<HeatRound> rounds = new List<HeatRound>();

            FinalNameEnum curFin = FinalNameEnum.Finale;
            HeatRound curRound;

            while (totalDrivers > 0)
            {
                curRound = new HeatRound(curFin);

                curRound.Qualifier = 2 * ScheuduleDrivers;
                switch (curFin)
                {
                    case FinalNameEnum.Finale:
                        if (totalDrivers > GroupSize) //Es müssen 1/2 Finale gefahren werden
                        {
                            curRound.Qualifier = 0;
                            curRound.Riser = GroupSize;
                        }    
                        else
                        {
                            curRound.Qualifier = totalDrivers;
                            curRound.Riser = totalDrivers;
                        }
                        break;

                    case FinalNameEnum.Finale_1_2:
                        curRound.Riser = GroupSize;
                        if (totalDrivers <= 2 * GroupSize) //Volles letztes Finale fahren
                        {
                            curRound.Qualifier = totalDrivers;
                        }
                        break;

                    default: //Alle anderen Finale
                        curRound.Riser = 2 * RisingDrivers;
                        if (totalDrivers <= GroupSize && AddLastFinal) //Letztes Finale zusammen fassen
                        {
                            curRound.Qualifier = totalDrivers;
                        }
                        else if (totalDrivers <= 2 * GroupSize) //Volles letztes Finale fahren
                        {
                            curRound.Qualifier = totalDrivers;
                        }
                        break;
                }

                if (curFin != FinalNameEnum.Finale)
                {
                    rounds.Last().Places = rounds.Last().Qualifier + curRound.Riser;
                }


                totalDrivers -= curRound.Qualifier;
                rounds.Add(curRound);
                curFin++;
            }

            rounds.Last().Places = rounds.Last().Qualifier;

            //rounds.Reverse();

            return rounds;
        }

        #endregion Internal services

        #region Events


        #endregion Events

        #region INotifyPropertyChanged Member
        /// <summary>
        /// Helpmethod, to call the <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="propName">Name of changed property</param>
        protected void PropChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        /// <summary>
        /// Updated property values available
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
