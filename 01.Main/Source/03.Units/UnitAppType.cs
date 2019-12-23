using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ulee.Utils;

namespace IsSoft.Sec.LedChecker
{
    #region Enum
    public enum EServoAxis
    { X_Stage, Y_Stage, Z_Prove, Z_LMK, Theta_LMK }

    public enum EAppState
    { Opening, Running, Closing }

    public enum ELogType
    { Note, Error, Exception }

    public enum ELedType
    { Disabled, Enabled, Black }

    public enum EDataSetMode
    { View, New, Modify }

    public enum EWorkType
    { Full, Sampling }

    public enum EOpticalType
    { None, Luminance, Color }

    public enum ETestDecision
    {
        [Description(" ")]
        Nt,
        [Description("OK")]
        Ok,
        [Description("NG")]
        Ng
    }

    public enum EBinType
    {
        [Description("OK")]
        Ok,
        [Description("NG")]
        Ng
    }

    public enum EBinLogic
    { OR, AND }

    public enum ELedCoordinateType
    { XY, StrLed }

    public enum EBinCondition
    {
        [Description(" = (Equal)")]
        Equal,
        [Description(" <> (Not Equal)")]
        NotEqual
    }

    public enum ETestWorkItem
    {
        No,
        ItemCode,
        ItemName,
        ItemRef,
        Empty1,
        TestPattern,
        BiasCH,
        BiasRange,
        BiasValue,
        ApplyTime,
        TransientTime,
        HumCounter,
        Empty2,
        //Optical,
        Integ_VL,
        Integ_X1,
        Integ_X2,
        Integ_Z,
        Empty3,
        Gain,
        Offet
    }

    public enum EReportWorkItem
    {
        No,
        ItemCode,
        ItemName,
        ItemRef,
        BiasCH,
        Empty1,
        Rank,
        Lower,
        Upper
    }

    public enum ETestItemCode
    {
        [Description("VF")]
        VF,
        [Description("IF")]
        IF,
        [Description("VR")]
        VR,
        [Description("IR")]
        IR,
        [Description("LMK Pattern")]
        LMK_Pattern,
        [Description("LMK Luminance")]
        LMK_Luminance,
        [Description("LMK Color")]
        LMK_Color,
        [Description("IC ON")]
        IC_ON,
        [Description("IC OFF")]
        IC_OFF,
        [Description("IC INIT")]
        IC_INIT,
        [Description("Safety Check")]
        Safety_Check,
        [Description("EEPROM Check")]
        EEPROM_Check,
        [Description("Watchdog Enable")]
        Watchdog_Enable,
        [Description("Watchdog Disable")]
        Watchdog_Disable,
        [Description("NTC Check")]
        NTC_Check,
        [Description("ND Filter ON")]
        ND_Filter_ON,
        [Description("ND Filter OFF")]
        ND_Filter_OFF
    }

    public enum EReportItemCode
    {
        [Description("VF")]
        VF,
        [Description("IF")]
        IF,
        [Description("VR")]
        VR,
        [Description("IR")]
        IR,
        [Description("Die Lv")]
        Die_Lv,
        [Description("Die X")]
        Die_X,
        [Description("Die Y")]
        Die_Y,
        [Description("Die XY")]
        Die_XY,
        [Description("Die Lv Uniformity")]
        Die_Lv_Uniformity,
        [Description("Die X Uniformity")]
        Die_X_Uniformity,
        [Description("Die Y Uniformity")]
        Die_Y_Uniformity,
        [Description("Die Contrast")]
        Die_Contrast,
        [Description("Die Glare")]
        Die_Glare,
        [Description("Cell Lv")]
        Cell_Lv,
        [Description("Cell X")]
        Cell_X,
        [Description("Cell Y")]
        Cell_Y,
        [Description("Cell XY")]
        Cell_XY,
        [Description("Cell Lv Uniformity")]
        Cell_Lv_Uniformity,
        [Description("Cell X Uniformity")]
        Cell_X_Uniformity,
        [Description("Cell Y Uniformity")]
        Cell_Y_Uniformity,
        [Description("Cell Contrast")]
        Cell_Contrast,
        [Description("IC ON")]
        IC_ON,
        [Description("IC OFF")]
        IC_OFF,
        [Description("IC INIT")]
        IC_INIT,
        [Description("Safety Check")]
        Safety_Check,
        [Description("EEPROM Check")]
        EEPROM_Check,
        [Description("Watchdog Enable")]
        Watchdog_Enable,
        [Description("Watchdog Disable")]
        Watchdog_Disable,
        [Description("NTC Check")]
        NTC_Check,
    }

    public enum EOutputType
    {
        [Description("None")]
        None,
        [Description("Group")]
        Group
    }

    public enum EOutputCalc
    {
        [Description("None")]
        None,
        [Description("Sum")]
        Sum,
        [Description("Avg")]
        Avg,
        [Description("Min")]
        Min,
        [Description("Max")]
        Max,
        [Description("UNIF")]
        UNIF,
        [Description("Hex")]
        Hex,
        [Description("Dec")]
        Dec,
        [Description("Bin")]
        Bin,
        [Description("CTEM")]
        CTEM,
        [Description("FTEM")]
        FTEM
    }

    public enum ECorrelation
    {
        [Description("None")]
        None,
        [Description("Gain")]
        Gain,
        [Description("Offset")]
        Offset,
        [Description("Gain&Offset")]
        GainAndOffset,
    }
    #endregion

    #region GridTypeFormat
    class ReportItemCodeFormat : IFormatProvider, ICustomFormatter
    {
        public ReportItemCodeFormat()
        {
        }

        public object GetFormat(Type type)
        {
            return this;
        }

        public string Format(string formatString, object arg, IFormatProvider formatProvider)
        {
            return ((EReportItemCode)arg).ToDescription();
        }
    }
    #endregion

    public class DialogSelectedItem
    {
        public string Name { get; set; }

        public Int64 RecNo { get; set; }

        public DialogSelectedItem()
        {
            Name = "";
            RecNo = 0;
        }
    }

    public class PatternRow
    {
        public LedProperty[] Leds;

        public int Index { get; set; }

        public string No { get { return $"{Index+1}"; } }
        public string F0 { get { return Leds[0].Text; } }
        public string F1 { get { return Leds[1].Text; } }
        public string F2 { get { return Leds[2].Text; } }
        public string F3 { get { return Leds[3].Text; } }
        public string F4 { get { return Leds[4].Text; } }
        public string F5 { get { return Leds[5].Text; } }
        public string F6 { get { return Leds[6].Text; } }
        public string F7 { get { return Leds[7].Text; } }
        public string F8 { get { return Leds[8].Text; } }
        public string F9 { get { return Leds[9].Text; } }
        public string F10 { get { return Leds[10].Text; } }
        public string F11 { get { return Leds[11].Text; } }
        public string F12 { get { return Leds[12].Text; } }
        public string F13 { get { return Leds[13].Text; } }
        public string F14 { get { return Leds[14].Text; } }
        public string F15 { get { return Leds[15].Text; } }
        public string F16 { get { return Leds[16].Text; } }
        public string F17 { get { return Leds[17].Text; } }
        public string F18 { get { return Leds[18].Text; } }
        public string F19 { get { return Leds[19].Text; } }
        public string F20 { get { return Leds[20].Text; } }
        public string F21 { get { return Leds[21].Text; } }
        public string F22 { get { return Leds[22].Text; } }
        public string F23 { get { return Leds[23].Text; } }
        public string F24 { get { return Leds[24].Text; } }
        public string F25 { get { return Leds[25].Text; } }
        public string F26 { get { return Leds[26].Text; } }
        public string F27 { get { return Leds[27].Text; } }
        public string F28 { get { return Leds[28].Text; } }
        public string F29 { get { return Leds[29].Text; } }
        public string F30 { get { return Leds[30].Text; } }
        public string F31 { get { return Leds[31].Text; } }
        public string F32 { get { return Leds[32].Text; } }
        public string F33 { get { return Leds[33].Text; } }
        public string F34 { get { return Leds[34].Text; } }
        public string F35 { get { return Leds[35].Text; } }
        public string F36 { get { return Leds[36].Text; } }
        public string F37 { get { return Leds[37].Text; } }
        public string F38 { get { return Leds[38].Text; } }
        public string F39 { get { return Leds[39].Text; } }
        public string F40 { get { return Leds[40].Text; } }
        public string F41 { get { return Leds[41].Text; } }
        public string F42 { get { return Leds[42].Text; } }
        public string F43 { get { return Leds[43].Text; } }
        public string F44 { get { return Leds[44].Text; } }
        public string F45 { get { return Leds[45].Text; } }
        public string F46 { get { return Leds[46].Text; } }
        public string F47 { get { return Leds[47].Text; } }
        public string F48 { get { return Leds[48].Text; } }
        public string F49 { get { return Leds[49].Text; } }
        public string F50 { get { return Leds[50].Text; } }
        public string F51 { get { return Leds[51].Text; } }
        public string F52 { get { return Leds[52].Text; } }
        public string F53 { get { return Leds[53].Text; } }
        public string F54 { get { return Leds[54].Text; } }
        public string F55 { get { return Leds[55].Text; } }
        public string F56 { get { return Leds[56].Text; } }
        public string F57 { get { return Leds[57].Text; } }
        public string F58 { get { return Leds[58].Text; } }
        public string F59 { get { return Leds[59].Text; } }
        public string F60 { get { return Leds[60].Text; } }
        public string F61 { get { return Leds[61].Text; } }
        public string F62 { get { return Leds[62].Text; } }
        public string F63 { get { return Leds[63].Text; } }
        public string F64 { get { return Leds[64].Text; } }
        public string F65 { get { return Leds[65].Text; } }
        public string F66 { get { return Leds[66].Text; } }
        public string F67 { get { return Leds[67].Text; } }
        public string F68 { get { return Leds[68].Text; } }
        public string F69 { get { return Leds[69].Text; } }
        public string F70 { get { return Leds[70].Text; } }
        public string F71 { get { return Leds[71].Text; } }
        public string F72 { get { return Leds[72].Text; } }
        public string F73 { get { return Leds[73].Text; } }
        public string F74 { get { return Leds[74].Text; } }
        public string F75 { get { return Leds[75].Text; } }
        public string F76 { get { return Leds[76].Text; } }
        public string F77 { get { return Leds[77].Text; } }
        public string F78 { get { return Leds[78].Text; } }
        public string F79 { get { return Leds[79].Text; } }
        public string F80 { get { return Leds[80].Text; } }
        public string F81 { get { return Leds[81].Text; } }
        public string F82 { get { return Leds[82].Text; } }
        public string F83 { get { return Leds[83].Text; } }
        public string F84 { get { return Leds[84].Text; } }
        public string F85 { get { return Leds[85].Text; } }
        public string F86 { get { return Leds[86].Text; } }
        public string F87 { get { return Leds[87].Text; } }
        public string F88 { get { return Leds[88].Text; } }
        public string F89 { get { return Leds[89].Text; } }
        public string F90 { get { return Leds[90].Text; } }
        public string F91 { get { return Leds[91].Text; } }
        public string F92 { get { return Leds[92].Text; } }
        public string F93 { get { return Leds[93].Text; } }
        public string F94 { get { return Leds[94].Text; } }
        public string F95 { get { return Leds[95].Text; } }
        public string F96 { get { return Leds[96].Text; } }
        public string F97 { get { return Leds[97].Text; } }
        public string F98 { get { return Leds[98].Text; } }
        public string F99 { get { return Leds[99].Text; } }

        public PatternRow(int index, bool shortText=true)
        {
            Index = index;
            Leds = new LedProperty[100];

            for (int i=0; i<100; i++)
            {
                Leds[i] = new LedProperty(shortText);
                Leds[i].X = i;
                Leds[i].Y = index;
            }
        }
    }

    public class LedProperty
    {
        private bool shortText;

        public Int64 RecNo { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public string Text
        {
            get
            {
                string str = "";

                switch (Type)
                {
                    case ELedType.Enabled:
                        str = $"{StringIndex}-{LedIndex}";

                        if (shortText == false)
                        {
                            if (TurnOn == true) str = "T " + str;
                            else str = "  " + str;

                            if (Measuring == true) str += " M";
                            else str += "  ";
                        }
                        break;
                }

                return str;
            }
        }

        public int StringIndex { get; set; }

        public int LedIndex { get; set; }

        public bool TurnOn { get; set; }

        public bool Measuring { get; set; }

        public ELedType Type { get; set; }

        public LedProperty(bool shortText=true)
        {
            this.shortText = shortText;
            RecNo = 0;
            X = 0;
            Y = 0;
            StringIndex = 0;
            LedIndex = 0;
            TurnOn = false;
            Measuring = false;
            Type = ELedType.Disabled;
        }
    }

    public class StringRow
    {
        public UlBinSets Sets { get; set; }
        public Int64 RecNo { get; set; }
        public int Index { get; set; }
        public string StringNo
        {
            get { return $"String{Index + 1}"; }
        }

        public bool SMU1 { get { return Sets[0]; } set { Sets[0] = value; } }
        public bool SMU2 { get { return Sets[1]; } set { Sets[1] = value; } }
        public bool SMU3 { get { return Sets[2]; } set { Sets[2] = value; } }
        public bool SMU4 { get { return Sets[3]; } set { Sets[3] = value; } }
        public bool SMU5 { get { return Sets[4]; } set { Sets[4] = value; } }
        public bool SMU6 { get { return Sets[5]; } set { Sets[5] = value; } }
        public bool SMU7 { get { return Sets[6]; } set { Sets[6] = value; } }
        public bool SMU8 { get { return Sets[7]; } set { Sets[7] = value; } }
        public bool SMU9 { get { return Sets[8]; } set { Sets[8] = value; } }
        public bool SMU10 { get { return Sets[9]; } set { Sets[9] = value; } }
        public bool SMU11 { get { return Sets[10]; } set { Sets[10] = value; } }
        public bool SMU12 { get { return Sets[11]; } set { Sets[11] = value; } }
        public bool SMU13 { get { return Sets[12]; } set { Sets[12] = value; } }
        public bool SMU14 { get { return Sets[13]; } set { Sets[13] = value; } }
        public bool SMU15 { get { return Sets[14]; } set { Sets[14] = value; } }
        public bool SMU16 { get { return Sets[15]; } set { Sets[15] = value; } }
        public bool SMU17 { get { return Sets[16]; } set { Sets[16] = value; } }
        public bool SMU18 { get { return Sets[17]; } set { Sets[17] = value; } }
        public bool SMU19 { get { return Sets[18]; } set { Sets[18] = value; } }
        public bool SMU20 { get { return Sets[19]; } set { Sets[19] = value; } }

        public StringRow(int index)
        {
            RecNo = 0;
            Index = index;
            Sets = new UlBinSets(8);
        }
    }

    public class TestWorkRow
    {
        public int Index { get; set; }

        public ETestItemCode ItemCode { get; set; }

        public string ItemName { get; set; }

        public string ItemRef { get; set; }

        public string TestPattern { get; set; }

        public string BiasCH { get; set; }

        public string BiasValue { get; set; }

        public string BiasRange { get; set; }

        public double ApplyTime { get; set; }

        public double TransientTime { get; set; }

        public int HumCounter { get; set; }

        public EOpticalType Optical { get; set; }

        public double IntegVL { get; set; }

        public double IntegX1 { get; set; }

        public double IntegX2 { get; set; }

        public double IntegZ { get; set; }

        public double Gain { get; set; }

        public double Offset { get; set; }

        public TestWorkRow()
        {
            Index = 0;
            ItemCode = ETestItemCode.VF;
            ItemName = EnumHelper.ToDescription(ItemCode);
            ItemRef = "None";
            TestPattern = "None(0)";
            BiasCH = "None";
            BiasValue = "None";
            BiasRange = "None";
            Optical = EOpticalType.None;
            IntegVL = 0.0001;
            IntegX1 = 0.0001;
            IntegX2 = 0.0001;
            IntegZ = 0.0001;
            Gain = 1;
        }
    }

    public class ReportWorkRow
    {
        public int Index { get; set; }

        public EReportItemCode ItemCode { get; set; }

        public string ItemName { get; set; }

        public string ItemRef { get; set; }

        public string BiasCH { get; set; }

        public string Rank { get; set; }

        public double Lower { get; set; }

        public double Upper { get; set; }

        public ReportWorkRow()
        {
            Index = 0;
            ItemCode = EReportItemCode.VF;
            ItemName = EnumHelper.ToDescription(ItemCode);
            ItemRef = "None";
            BiasCH = "None";
            Rank = "None(0)";
        }
    }

    public class TestPatternRow
    {
        public Int64 RecNo { get; set; }

        public string Name { get; set; }

        public string Smu { get; set; }

        public TestPatternRow(Int64 recNo, string name, string smu)
        {
            RecNo = recNo;
            Name = name;
            Smu = smu;
        }
    }

    public class TestRankRow
    {
        public int Index { get; set; }

        public string Name { get; set; }

        public double Lower1 { get; set; }

        public double Upper1 { get; set; }

        public double Lower2 { get; set; }

        public double Upper2 { get; set; }

        public TestRankRow()
        {
            Index = 0;
            Name = "None";
            Lower1 = 0;
            Upper1 = 0;
            Lower2 = 0;
            Upper2 = 0;
        }
    }

    public class SelectedRankRow
    {
        public Int64 RecNo { get; set; }

        public string Name { get; set; }

        public string NameRecNo
        { get { return $"{Name}({RecNo})"; } }

        public double Lower { get; set; }

        public double Upper { get; set; }

        public SelectedRankRow()
        {
            RecNo = 0;
            Name = "None";
            Lower = 0;
            Upper = 0;
        }
    }

    public class RecipeBinRow
    {
        public Int64 RecNo { get; set; }

        public EBinType Type { get; set; }

        public int Index { get; set; }

        public string Name { get; set; }

        public Color Mark { get; set; }

        public RecipeBinRow()
        {
            Clear();
        }

        public void Clear(int index=0)
        {
            RecNo = 0;
            Type = EBinType.Ok;
            Index = index;
            Name = "";
            Mark = Color.FromKnownColor(KnownColor.Black);
        }
    }

    public class BinRow
    {
        public List<BinFormula> Formulas;

        public Int64 RecNo { get; set; }

        public int Index { get; set; }

        public string Name { get; set; }

        public Color Mark { get; set; }

        public EBinType Type { get; set; }

        public EBinLogic Logic1 { get { return Formulas[0].Logic; } set { Formulas[0].Logic = value; } }

        public string Formula1 { get { return Formulas[0].Formula; } set { Formulas[0].Formula = value; } }

        public EBinLogic Logic2 { get { return Formulas[1].Logic; } set { Formulas[1].Logic = value; } }

        public string Formula2 { get { return Formulas[1].Formula; } set { Formulas[1].Formula = value; } }

        public EBinLogic Logic3 { get { return Formulas[2].Logic; } set { Formulas[2].Logic = value; } }

        public string Formula3 { get { return Formulas[2].Formula; } set { Formulas[2].Formula = value; } }

        public EBinLogic Logic4 { get { return Formulas[3].Logic; } set { Formulas[3].Logic = value; } }

        public string Formula4 { get { return Formulas[3].Formula; } set { Formulas[3].Formula = value; } }

        public EBinLogic Logic5 { get { return Formulas[4].Logic; } set { Formulas[4].Logic = value; } }

        public string Formula5 { get { return Formulas[4].Formula; } set { Formulas[4].Formula = value; } }

        public EBinLogic Logic6 { get { return Formulas[5].Logic; } set { Formulas[5].Logic = value; } }

        public string Formula6 { get { return Formulas[5].Formula; } set { Formulas[5].Formula = value; } }

        public EBinLogic Logic7 { get { return Formulas[6].Logic; } set { Formulas[6].Logic = value; } }

        public string Formula7 { get { return Formulas[6].Formula; } set { Formulas[6].Formula = value; } }

        public EBinLogic Logic8 { get { return Formulas[7].Logic; } set { Formulas[7].Logic = value; } }

        public string Formula8 { get { return Formulas[7].Formula; } set { Formulas[7].Formula = value; } }

        public EBinLogic Logic9 { get { return Formulas[8].Logic; } set { Formulas[8].Logic = value; } }

        public string Formula9 { get { return Formulas[8].Formula; } set { Formulas[8].Formula = value; } }

        public EBinLogic Logic10 { get { return Formulas[9].Logic; } set { Formulas[9].Logic = value; } }

        public string Formula10 { get { return Formulas[9].Formula; } set { Formulas[9].Formula = value; } }

        public EBinLogic Logic11 { get { return Formulas[10].Logic; } set { Formulas[10].Logic = value; } }

        public string Formula11 { get { return Formulas[10].Formula; } set { Formulas[10].Formula = value; } }

        public EBinLogic Logic12 { get { return Formulas[11].Logic; } set { Formulas[11].Logic = value; } }

        public string Formula12 { get { return Formulas[11].Formula; } set { Formulas[11].Formula = value; } }

        public EBinLogic Logic13 { get { return Formulas[12].Logic; } set { Formulas[12].Logic = value; } }

        public string Formula13 { get { return Formulas[12].Formula; } set { Formulas[12].Formula = value; } }

        public EBinLogic Logic14 { get { return Formulas[13].Logic; } set { Formulas[13].Logic = value; } }

        public string Formula14 { get { return Formulas[13].Formula; } set { Formulas[13].Formula = value; } }

        public EBinLogic Logic15 { get { return Formulas[14].Logic; } set { Formulas[14].Logic = value; } }

        public string Formula15 { get { return Formulas[14].Formula; } set { Formulas[14].Formula = value; } }

        public EBinLogic Logic16 { get { return Formulas[15].Logic; } set { Formulas[15].Logic = value; } }

        public string Formula16 { get { return Formulas[15].Formula; } set { Formulas[15].Formula = value; } }

        public EBinLogic Logic17 { get { return Formulas[16].Logic; } set { Formulas[16].Logic = value; } }

        public string Formula17 { get { return Formulas[16].Formula; } set { Formulas[16].Formula = value; } }

        public EBinLogic Logic18 { get { return Formulas[17].Logic; } set { Formulas[17].Logic = value; } }

        public string Formula18 { get { return Formulas[17].Formula; } set { Formulas[17].Formula = value; } }

        public EBinLogic Logic19 { get { return Formulas[18].Logic; } set { Formulas[18].Logic = value; } }

        public string Formula19 { get { return Formulas[18].Formula; } set { Formulas[18].Formula = value; } }

        public EBinLogic Logic20 { get { return Formulas[19].Logic; } set { Formulas[19].Logic = value; } }

        public string Formula20 { get { return Formulas[19].Formula; } set { Formulas[19].Formula = value; } }

        public EBinLogic Logic21 { get { return Formulas[20].Logic; } set { Formulas[20].Logic = value; } }

        public string Formula21 { get { return Formulas[20].Formula; } set { Formulas[20].Formula = value; } }

        public EBinLogic Logic22 { get { return Formulas[21].Logic; } set { Formulas[21].Logic = value; } }

        public string Formula22 { get { return Formulas[21].Formula; } set { Formulas[21].Formula = value; } }

        public EBinLogic Logic23 { get { return Formulas[22].Logic; } set { Formulas[22].Logic = value; } }

        public string Formula23 { get { return Formulas[22].Formula; } set { Formulas[22].Formula = value; } }

        public EBinLogic Logic24 { get { return Formulas[23].Logic; } set { Formulas[23].Logic = value; } }

        public string Formula24 { get { return Formulas[23].Formula; } set { Formulas[23].Formula = value; } }

        public EBinLogic Logic25 { get { return Formulas[24].Logic; } set { Formulas[24].Logic = value; } }

        public string Formula25 { get { return Formulas[24].Formula; } set { Formulas[24].Formula = value; } }

        public EBinLogic Logic26 { get { return Formulas[25].Logic; } set { Formulas[25].Logic = value; } }

        public string Formula26 { get { return Formulas[25].Formula; } set { Formulas[25].Formula = value; } }

        public EBinLogic Logic27 { get { return Formulas[26].Logic; } set { Formulas[26].Logic = value; } }

        public string Formula27 { get { return Formulas[26].Formula; } set { Formulas[26].Formula = value; } }

        public EBinLogic Logic28 { get { return Formulas[27].Logic; } set { Formulas[27].Logic = value; } }

        public string Formula28 { get { return Formulas[27].Formula; } set { Formulas[27].Formula = value; } }

        public EBinLogic Logic29 { get { return Formulas[28].Logic; } set { Formulas[28].Logic = value; } }

        public string Formula29 { get { return Formulas[28].Formula; } set { Formulas[28].Formula = value; } }

        public EBinLogic Logic30 { get { return Formulas[29].Logic; } set { Formulas[29].Logic = value; } }

        public string Formula30 { get { return Formulas[29].Formula; } set { Formulas[29].Formula = value; } }

        public BinRow()
        {
            Formulas = new List<BinFormula>();

            for (int i=0; i<30; i++)
            {
                Formulas.Add(new BinFormula());
            }
        }

        public void Clear()
        {
            foreach (BinFormula formula in Formulas)
            {
                formula.Clear();
            }
        }
    }

    public class BinFormula
    {
        public Int64 RecNo { get; set; }

        public EBinLogic Logic { get; set; }

        public string Formula { get; set; }

        public BinFormula()
        {
            Clear();
        }

        public void Clear()
        {
            RecNo = 0;
            Logic = EBinLogic.OR;
            Formula = "";
        }
    }
}
