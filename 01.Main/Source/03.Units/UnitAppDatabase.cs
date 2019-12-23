using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirebirdSql.Data.FirebirdClient;

using Ulee.Database.Firebird;

namespace IsSoft.Sec.LedChecker
{
    public class AppDatabase : UlFirebird
    {
        public FbConnection Connect { get { return connect; } }

        public AppDatabase(FbServerType type = FbServerType.Default) : base(type)
        {
        }
    }

    public class RecipeDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public string Name { get; set; }

        public string Memo { get; set; }

        public double ST1_X { get; set; }

        public double ST1_Y { get; set; }

        public string ST1_QR { get; set; }

        public double ST2_X { get; set; }

        public double ST2_Y { get; set; }

        public string ST2_QR { get; set; }

        public RecipeDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                " select * from TB_RECIPE " +
                " where pk_recno>0 " +
                " order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Select(Int64 recNo, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_RECIPE " + 
                $" where pk_recno={recNo} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void SelectName(string name, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_RECIPE " +
                $" where code = '{name}' ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Select(string name, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_RECIPE " +
                $" where code like '{name}%%' and pk_recno>0 " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_RECIPE values ({RecNo}, '{Name}', '{Memo}', " +
                $" {ST1_X}, {ST1_Y}, '{ST1_QR}', {ST1_X}, {ST1_Y}, '{ST1_QR}') ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql = 
                $" update TB_RECIPE set code='{Name}', memo='{Memo}', " +
                $" st1_x={ST1_X}, st1_y={ST1_Y}, st1_qr='{ST1_QR}', " +
                $" st2_x={ST2_X}, st2_y={ST2_Y}, st2_qr='{ST2_QR}' " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_RECIPE where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                Name = "";
                Memo = "";
                ST1_X = 0;
                ST1_Y = 0;
                ST1_QR = "";
                ST2_X = 0;
                ST2_Y = 0;
                ST2_QR = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            Name = Convert.ToString(row["code"]);
            Memo = Convert.ToString(row["memo"]);
            ST1_X = Convert.ToDouble(row["st1_x"]);
            ST1_Y = Convert.ToDouble(row["st1_y"]);
            ST1_QR = Convert.ToString(row["st1_qr"]);
            ST2_X = Convert.ToDouble(row["st2_x"]);
            ST2_Y = Convert.ToDouble(row["st2_y"]);
            ST2_QR = Convert.ToString(row["st2_qr"]);
        }
    }

    public class SmuDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public int StringNo { get; set; }

        public UInt64 Sets { get; set; }

        public SmuDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 recipeNo, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_SMU where fk_recipeno={recipeNo} order by strno asc ";
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_SMU values ({RecNo}, {RecipeNo}, {StringNo}, {Sets}) ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_SMU set strno={StringNo}, sets={Sets} " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_SMU where fk_recipeno={RecipeNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                RecipeNo = 0;
                StringNo = 0;
                Sets = 0;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            RecipeNo = Convert.ToInt64(row["fk_recipeno"]);
            StringNo = Convert.ToInt32(row["strno"]);
            Sets = Convert.ToUInt64(row["sets"]);
        }
    }

    public class MasterPatternDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public int XLength { get; set; }

        public int YHeight { get; set; }

        public int StrCount { get; set; }

        public int LedCount { get; set; }

        public MasterPatternDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 recipeNo, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_MASTERPATTERN where fk_recipeno={recipeNo} order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_MASTERPATTERN values ({RecNo}, " +
                $" {RecipeNo}, {XLength}, {YHeight}, {StrCount}, {LedCount}) ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_MASTERPATTERN set " +
                $" x_length={XLength}, y_height={YHeight}, strcount={StrCount}, ledcount={LedCount} " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_MASTERPATTERN where fk_recipeno={RecipeNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                RecipeNo = 0;
                XLength = 0;
                YHeight = 0;
                StrCount = 0;
                LedCount = 0;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            RecipeNo = Convert.ToInt64(row["fk_recipeno"]);
            XLength = Convert.ToInt32(row["x_length"]);
            YHeight = Convert.ToInt32(row["y_height"]);
            StrCount = Convert.ToInt32(row["strcount"]);
            LedCount = Convert.ToInt32(row["ledcount"]);
        }
    }

    public class MasterPatternLedDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 MasterPatternNo { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int StrNo { get; set; }

        public int LedNo { get; set; }

        public ELedType Type { get; set; }

        public MasterPatternLedDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 masterPatternNo, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_MASTERPATTERN_LED where fk_masterpatternno={masterPatternNo} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_MASTERPATTERN_LED values ({RecNo}, " +
                $" {MasterPatternNo}, {X}, {Y}, {StrNo}, {LedNo}, {(int)Type}) ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_MASTERPATTERN_LED set " +
                $" x={X}, y={Y}, strno={StrNo}, ledno={LedNo}, enabled={(int)Type} " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_MASTERPATTERN_LED where fk_masterpatternno={MasterPatternNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                MasterPatternNo = 0;
                X = 0;
                Y = 0;
                StrNo = 0;
                LedNo = 0;
                Type = ELedType.Disabled;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            MasterPatternNo = Convert.ToInt64(row["fk_masterpatternno"]);
            X = Convert.ToInt32(row["x"]);
            Y = Convert.ToInt32(row["y"]);
            StrNo = Convert.ToInt32(row["strno"]);
            LedNo = Convert.ToInt32(row["ledno"]);
            Type = (ELedType)Convert.ToInt32(row["enabled"]);
        }
    }

    public class SlavePatternDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 MasterPatternNo { get; set; }

        public string Name { get; set; }

        public string Memo { get; set; }

        public SlavePatternDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 masterNo, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_SLAVEPATTERN " + 
                $" where fk_masterpatternno={masterNo} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void SelectIncludeNone(Int64 masterNo, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_SLAVEPATTERN " +
                $" where pk_recno=0 or fk_masterpatternno={masterNo} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_SLAVEPATTERN values " +
                $" ({RecNo}, {MasterPatternNo}, '{Name}', '{Memo}') ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_SLAVEPATTERN set " +
                $" patternname='{Name}', memo='{Memo}' " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_SLAVEPATTERN where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(Int64 masterNo, FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_SLAVEPATTERN where fk_masterpatternno={masterNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public string GetNameRecNoString(Int64 recNo)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_SLAVEPATTERN " +
                $" where pk_recno={recNo} ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);

            if (Empty == true) return "None(0)";

            DataRow row = dataSet.Tables[0].Rows[0];

            return $"{Convert.ToString(row["patternname"])}({Convert.ToString(row["pk_recno"])})";
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                MasterPatternNo = 0;
                Name = "";
                Memo = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            MasterPatternNo = Convert.ToInt64(row["fk_masterpatternno"]);
            Name = Convert.ToString(row["patternname"]);
            Memo = Convert.ToString(row["memo"]);
        }
    }

    public class SlavePatternLedDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 SlavePatternNo { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int StrNo { get; set; }

        public int LedNo { get; set; }

        public bool TurnOn { get; set; }

        public bool Measuring { get; set; }

        public ELedType Type { get; set; }

        public SlavePatternLedDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 slavePatternNo, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_SLAVEPATTERN_LED where fk_slavepatternno={slavePatternNo} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            int turnon = (TurnOn == true) ? 1 : 0;
            int measuring = (Measuring == true) ? 1 : 0;
            string sql =
                $" insert into TB_SLAVEPATTERN_LED values ({RecNo}, {SlavePatternNo}, " +
                $" {X}, {Y}, {StrNo}, {LedNo}, {turnon}, {measuring}, {(int)Type}) ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            int turnon = (TurnOn == true) ? 1 : 0;
            int measuring = (Measuring == true) ? 1 : 0;
            string sql =
                $" update TB_SLAVEPATTERN_LED set fk_slavepatternno={SlavePatternNo}, x={X}, y={Y}, " +
                $" strno={StrNo}, ledno={LedNo}, turnon={turnon}, measuring={measuring}, enabled={(int)Type} " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_SLAVEPATTERN_LED where fk_slavepatternno={SlavePatternNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                SlavePatternNo = 0;
                X = 0;
                Y = 0;
                StrNo = 0;
                LedNo = 0;
                TurnOn = false;
                Measuring = false;
                Type = ELedType.Disabled;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            SlavePatternNo = Convert.ToInt64(row["fk_slavepatternno"]);
            X = Convert.ToInt32(row["x"]);
            Y = Convert.ToInt32(row["y"]);
            StrNo = Convert.ToInt32(row["strno"]);
            LedNo = Convert.ToInt32(row["ledno"]);
            TurnOn = (Convert.ToInt32(row["turnon"]) == 1) ? true : false;
            Measuring = (Convert.ToInt32(row["measuring"]) == 1) ? true : false;
            Type = (ELedType)Convert.ToInt32(row["enabled"]);
        }
    }

    public class TestWorkDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public Int64 SlavePatternNo { get; set; }

        public EWorkType Type { get; set; }

        public int Index { get; set; }

        public ETestItemCode ItemCode { get; set; }

        public string ItemName { get; set; }

        public string ItemRef { get; set; }

        public string TestPattern { get; set; }

        public string BiasValue { get; set; }

        public string BiasRange { get; set; }

        public string BiasCH { get; set; }

        public double ApplyTime { get; set; }

        public double TransientTime { get; set; }

        public int HumCount { get; set; }

        public EOpticalType Optical { get; set; }

        public double IntegVL { get; set; }

        public double IntegX1 { get; set; }

        public double IntegX2 { get; set; }

        public double IntegZ { get; set; }

        public double Gain { get; set; }

        public double Offset { get; set; }

        public TestWorkDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 recipeNo, EWorkType type, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select ta.*, tb.patternname from TB_TESTWORK ta " +
                $" join TB_SLAVEPATTERN tb on tb.pk_recno=ta.fk_slavepatternno " +
                $" where ta.fk_recipeno={recipeNo} and ta.worktype={(int)type} " +
                $" order by ta.pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_TESTWORK values " +
                $" ({RecNo}, {RecipeNo}, {SlavePatternNo}, {(int)Type}, {Index}, {(int)ItemCode}, '{ItemName}', " +
                $" '{ItemRef}', '{BiasValue}', '{BiasRange}', '{BiasCH}', {ApplyTime}, {TransientTime}, {HumCount}, " +
                $" {(int)Optical}, {IntegVL}, {IntegX1}, {IntegX2}, {IntegZ}, {Gain}, {Offset}) ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_TESTWORK set " +
                $" fk_recipeno={RecipeNo}, fk_slavepatternno={SlavePatternNo}, worktype={(int)Type}, " +
                $" workno={Index}, itemcode={(int)ItemCode}, itemname='{ItemName}', itemref='{ItemRef}', " +
                $" bias_value='{BiasValue}', bias_range='{BiasRange}', bias_ch='{BiasCH}', applytime={ApplyTime}, " +
                $" transtime={TransientTime}, humcnt={HumCount}, optical={(int)Optical}, integ_vl={IntegVL}, " +
                $" integ_x1={IntegX1}, integ_x2={IntegX1}, integ_z={IntegZ}, gain={Gain}, offset={Offset} " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_TESTWORK where fk_recipeno={RecipeNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                RecipeNo = 0;
                SlavePatternNo = 0;
                Type = EWorkType.Full;
                Index = 0;
                ItemCode = ETestItemCode.VF;
                ItemName = "VF";
                ItemRef = "None";
                TestPattern = "None";
                BiasValue = "None";
                BiasRange = "None";
                BiasCH = "None";
                ApplyTime = 0;
                TransientTime = 0;
                HumCount = 0;
                Optical = EOpticalType.None;
                IntegVL = 0;
                IntegX1 = 0;
                IntegX2 = 0;
                IntegZ = 0;
                Gain = 0;
                Offset = 0;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            RecipeNo = Convert.ToInt64(row["fk_recipeno"]);
            SlavePatternNo = Convert.ToInt64(row["fk_slavepatternno"]);
            Type = (EWorkType)Convert.ToInt32(row["worktype"]);
            Index = Convert.ToInt32(row["workno"]);
            ItemCode = (ETestItemCode)Convert.ToInt32(row["itemcode"]);
            ItemName = Convert.ToString(row["itemname"]);
            ItemRef = Convert.ToString(row["itemref"]);
            TestPattern = Convert.ToString(row["patternname"]);
            BiasValue = Convert.ToString(row["bias_value"]);
            BiasRange = Convert.ToString(row["bias_range"]);
            BiasCH = Convert.ToString(row["bias_ch"]);
            ApplyTime = Convert.ToDouble(row["applytime"]);
            TransientTime = Convert.ToDouble(row["transtime"]);
            HumCount = Convert.ToInt32(row["humcnt"]);
            Optical = (EOpticalType)Convert.ToInt32(row["optical"]);
            IntegVL = Convert.ToDouble(row["integ_vl"]);
            IntegX1 = Convert.ToDouble(row["integ_x1"]);
            IntegX2 = Convert.ToDouble(row["integ_x2"]);
            IntegZ = Convert.ToDouble(row["integ_z"]);
            Gain = Convert.ToDouble(row["gain"]);
            Offset = Convert.ToDouble(row["offset"]);
        }
    }

    public class ReportWorkDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public EWorkType Type { get; set; }

        public int Index  { get; set; }

        public EReportItemCode ItemCode { get; set; }

        public string ItemName { get; set; }

        public string ItemRef { get; set; }

        public string BiasCH { get; set; }

        public string Rank { get; set; }

        public double Lower { get; set; }

        public double Upper { get; set; }

        public ReportWorkDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 recipeNo, EWorkType type, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_REPORTWORK " +
                $" where fk_recipeno={recipeNo} and worktype={(int)type} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_REPORTWORK values " +
                $" ({RecNo}, {RecipeNo}, {(int)Type}, {Index}, {(int)ItemCode}, " +
                $" '{ItemName}', '{ItemRef}', '{BiasCH}', '{Rank}', {Lower}, {Upper})";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_REPORTWORK set " +
                $" fk_recipeno={RecipeNo}, worktype={(int)Type}, workno={Index}, " +
                $" itemcode={(int)ItemCode}, itemname='{ItemName}', itemref='{ItemRef}', " +
                $" biasch='{BiasCH}', rank='{Rank}', lowevalue={Lower}, uppervalue={Upper} " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_REPORTWORK where fk_recipeno={RecipeNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                RecipeNo = 0;
                Type = EWorkType.Full;
                Index = 0;
                ItemCode = EReportItemCode.VF;
                ItemName = "VF";
                ItemRef = "None";
                BiasCH = "None";
                Rank = "None(0)";
                Lower = 0;
                Upper = 0;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            RecipeNo = Convert.ToInt64(row["fk_recipeno"]);
            Type = (EWorkType)Convert.ToInt32(row["worktype"]);
            Index = Convert.ToInt32(row["workno"]);
            ItemCode = (EReportItemCode)Convert.ToInt32(row["itemcode"]);
            ItemName = Convert.ToString(row["itemname"]);
            ItemRef = Convert.ToString(row["itemref"]);
            BiasCH = Convert.ToString(row["biasch"]);
            Rank = Convert.ToString(row["rank"]);
            Lower = Convert.ToDouble(row["lowervalue"]);
            Upper = Convert.ToDouble(row["uppervalue"]);
        }
    }

    public class RankDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public EReportItemCode ItemCode { get; set; }

        public string Name { get; set; }

        public string Memo { get; set; }

        public RankDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 recipeNo, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_RANK " +
                $" where fk_recipeno={recipeNo} " +
                $" order by itemcode asc, pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Select(Int64 recipeNo, EReportItemCode code, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_RANK " +
                $" where fk_recipeno={recipeNo} and itemcode={(int)code} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_RANK values " +
                $" ({RecNo}, {RecipeNo}, {(int)ItemCode}, '{Name}', '{Memo}') ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_RANK set " +
                $" fk_recipeno={RecipeNo}, itemcode={(int)ItemCode}, " +
                $" rankname='{Name}', memo='{Memo}' " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_RANK where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                RecipeNo = 0;
                ItemCode = EReportItemCode.VF;
                Name = "None";
                Memo = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            RecipeNo = Convert.ToInt64(row["fk_recipeno"]);
            ItemCode = (EReportItemCode)Convert.ToInt32(row["itemcode"]);
            Name = Convert.ToString(row["rankname"]);
            Memo = Convert.ToString(row["memo"]);
        }
    }

    public class RankRowDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 RankNo { get; set; }

        public int Index { get; set; }

        public string Name { get; set; }

        public double Lower1 { get; set; }

        public double Upper1 { get; set; }

        public double Lower2 { get; set; }

        public double Upper2 { get; set; }

        public RankRowDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 rankNo, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_RANKROW " +
                $" where fk_rankno={rankNo} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_RANKROW values " +
                $" ({RecNo}, {RankNo}, {Index}, '{Name}', {Lower1}, {Upper1}, {Lower2}, {Upper2}) ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_RANKROW set " +
                $" fk_rankno={RankNo}, rowindex={Index}, rowname='{Name}', " +
                $" lower1={Lower1}, upper1={Upper1}, lower2={Lower2}, upper2={Upper2} " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_RANKROW where fk_rankno={RankNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                RankNo = 0;
                Index = 0;
                Name = "None";
                Lower1 = 0;
                Upper1 = 0;
                Lower2 = 0;
                Upper2 = 0;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            RankNo = Convert.ToInt64(row["fk_rankno"]);
            Index = Convert.ToInt32(row["rowindex"]);
            Name = Convert.ToString(row["rowname"]);
            Lower1 = Convert.ToDouble(row["lower1"]);
            Upper1 = Convert.ToDouble(row["upper1"]);
            Lower2 = Convert.ToDouble(row["lower2"]);
            Upper2 = Convert.ToDouble(row["upper2"]);
        }
    }

    public class BinDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public EBinType Type { get; set; }

        public int Index { get; set; }

        public string Name { get; set; }

        public Color Mark { get; set; }


        public BinDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 recipeNo, FbTransaction trans = null)
        {
            
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_BIN " +
                $" where fk_recipeno={recipeNo} " +
                $" order by binindex asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_BIN values " +
                $" ({RecNo}, {RecipeNo}, {(int)Type}, {Index}, '{Name}', {Mark.ToArgb()}) ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_BIN set " +
                $" fk_recipeno={RecipeNo}, bintype={(int)Type}, " +
                $" binindex={Index}, binname='{Name}', mark={Mark.ToArgb()} " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(Int64 recipeNo, FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_BIN where fk_recipeno={recipeNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                RecipeNo = 0;
                Type = EBinType.Ok;
                Index = 0;
                Name = "None";
                Mark = Color.Black;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            RecipeNo = Convert.ToInt64(row["fk_recipeno"]);
            Type = (EBinType)Convert.ToInt32(row["bintype"]);
            Index = Convert.ToInt32(row["binindex"]);
            Name = Convert.ToString(row["binname"]);
            Mark = Color.FromArgb(Convert.ToInt32(row["mark"]));
        }
    }

    public class BinFormulaDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 BinNo { get; set; }

        public EWorkType WorkType { get; set; }

        public EBinLogic Logic { get; set; }

        public string Formula { get; set; }

        public BinFormulaDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 binNo, EWorkType workType, FbTransaction trans = null)
        {

            SetTrans(trans);
            command.CommandText =
                $" select * from TB_BINFORMULA " +
                $" where fk_binno={binNo} and worktype={(int)workType} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_BINFORMULA values " +
                $" ({RecNo}, {BinNo}, {(int)WorkType}, {(int)Logic}, '{Formula}') ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_BINFORMULA set " +
                $" fk_binno={BinNo}, worktype={(int)WorkType}, logic={(int)Logic}, formula='{Formula}' " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(Int64 recipeNo, FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_BINFORMULA ta where exists " +
                $" (select * from TB_BIN tb where tb.pk_recno=ta.fk_binno and tb.fk_recipeno={recipeNo}) ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                BinNo = 0;
                WorkType = EWorkType.Full;
                Logic = EBinLogic.OR;
                Formula = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            BinNo = Convert.ToInt64(row["fk_binno"]);
            WorkType = (EWorkType)Convert.ToInt32(row["worktype"]);
            Logic = (EBinLogic)Convert.ToInt32(row["logic"]);
            Formula = Convert.ToString(row["formula"]);
        }
    }

    public class TestCounterDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public string TestDate { get; set; }

        public int TotalCount { get; set; }

        public int OkCount { get; set; }

        public int NgCount { get; set; }

        public TestCounterDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_TESTCOUNTER " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Select(Int64 recipeNo, string testDate, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_TESTCOUNTER " +
                $" where fk_recipeno={recipeNo} and testdate={testDate.Trim()} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_TESTCOUNTER values " +
                $" ({RecNo}, {RecipeNo}, {TestDate}, {TotalCount}, {OkCount}, {NgCount}) ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_TESTCOUNTER set " +
                $" totalcnt={TotalCount}, okcnt={OkCount}, ngcnt={NgCount} " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_TESTCOUNTER where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                RecipeNo = 0;
                TestDate = "";
                TotalCount = 0;
                OkCount = 0;
                NgCount = 0;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            RecipeNo = Convert.ToInt64(row["fk_recipeno"]);
            TestDate = Convert.ToString(row["testdate"]);
            TotalCount = Convert.ToInt32(row["totalcnt"]);
            OkCount = Convert.ToInt32(row["okcnt"]);
            NgCount = Convert.ToInt32(row["ngcnt"]);
        }
    }

    public class TestHeadDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 RecipeNo { get; set; }

        public Int64 BinNo { get; set; }

        public EWorkType Type { get; set; }

        public string StartTime { get; set; }

        public string ElapsedTime { get; set; }

        public TestHeadDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_TESTHEAD " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Select(Int64 recipeNo, EWorkType type, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_TESTHEAD " +
                $" where fk_recipeno={recipeNo} and worktype={(int)type} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_TESTHEAD values " +
                $" ({RecNo}, {RecipeNo}, {BinNo}, {(int)Type}, '{StartTime}', '{ElapsedTime}') ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_TESTHEAD set " +
                $" fk_recipeno={RecipeNo}, fk_binno={BinNo}, worktype={(int)Type} " +
                $" starttime='{StartTime}', elapsedtime='{ElapsedTime}' " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_TESTHEAD where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                RecipeNo = 0;
                BinNo = 0;
                Type = EWorkType.Full;
                StartTime = "";
                ElapsedTime = "";
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            RecipeNo = Convert.ToInt64(row["fk_recipeno"]);
            BinNo = Convert.ToInt64(row["fk_binno"]);
            Type = (EWorkType)Convert.ToInt32(row["worktype"]);
            StartTime = Convert.ToString(row["starttime"]);
            ElapsedTime = Convert.ToString(row["elapsedtime"]);
        }
    }

    public class TestDataDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 TestHeadNo { get; set; }

        public Int64 TestWorkNo { get; set; }

        public Int64 RankRowNo { get; set; }

        public string RankName { get; set; }

        public EReportItemCode ItemCode { get; set; }

        public string ItemName { get; set; }

        public ETestDecision Decision { get; set; }

        public double X_Value { get; set; }

        public double Y_Value { get; set; }

        public TestDataDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select ta.*, tb.itemcode, tb.itemname, tc.rowname from TB_TESTDATA ta " +
                $" join TB_TESTWORK tb on tb.pk_recno=ta.fk_testworkno " +
                $" join TB_RANKROW tc on tc.pk_recno=ta.fk_rankrowno " +
                $" order by ta.pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Select(Int64 headNo, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select ta.*, tb.itemcode, tb.itemname, tc.rowname from TB_TESTDATA ta " +
                $" join TB_TESTWORK tb on tb.pk_recno=ta.fk_testworkno " +
                $" join TB_RANKROW tc on tc.pk_recno=ta.fk_rankrowno " +
                $" where ta.fk_testheadno={headNo} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            string sql =
                $" insert into TB_TESTDATA values " +
                $" ({RecNo}, {TestHeadNo}, {TestWorkNo}, {RankRowNo}, {(int)Decision}, {X_Value}, {Y_Value}) ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_TESTDATA where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                TestHeadNo = 0;
                TestWorkNo = 0;
                RankRowNo = 0;
                Decision = ETestDecision.Nt;
                X_Value = 0;
                Y_Value = 0;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            TestHeadNo = Convert.ToInt64(row["fk_testheadno"]);
            TestWorkNo = Convert.ToInt64(row["fk_testworkno"]);
            RankRowNo = Convert.ToInt64(row["fk_rankrowno"]);
            RankName = Convert.ToString(row["rowname"]);
            ItemCode = (EReportItemCode)Convert.ToInt32(row["itemcode"]);
            ItemName = Convert.ToString(row["itemname"]);
            Decision = (ETestDecision)Convert.ToInt32(row["decision"]);
            X_Value = Convert.ToDouble(row["x_val"]);
            Y_Value = Convert.ToDouble(row["y_val"]);
        }
    }

    public class TestRawDataDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 TestDataNo { get; set; }

        public int RawType { get; set; }

        public byte[] RawData { get; set; }

        public TestRawDataDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 testDataNo, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_TESTRAWDATA " +
                $" where fk_testdatano={testDataNo} " +
                $" order by pk_recno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        {
            if (RawData == null) return;
            if (RawData.Length == 0) return;

            string sql =
                $" insert into TB_TESTRAWDATA values " +
                $" ({RecNo}, {TestDataNo}, {RawType}, @rawdata) ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;

                command.Parameters.Clear();
                command.Parameters.Add("@rawdata", FbDbType.Binary);
                command.Parameters["@rawdata"].Value = RawData;

                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_TESTRAWDATA set " +
                $" fk_testdatano={TestDataNo}, rawtype={RawType}, @rawdata " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;

                command.Parameters.Clear();
                command.Parameters.Add("@rawdata", FbDbType.Binary);
                command.Parameters["@rawdata"].Value = RawData;

                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_TESTRAWDATA where fk_testdatano={TestDataNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                TestDataNo = 0;
                RawType = 0;
                RawData = null;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            TestDataNo = Convert.ToInt64(row["fk_testdatano"]);
            RawType = Convert.ToInt32(row["rawtype"]);
            RawData = (byte[])row["rawdata"];
        }
    }

    public class BinCounterDataSet : UlDataSet
    {
        public Int64 RecNo { get; set; }

        public Int64 TestCounterNo { get; set; }

        public Int64 BinNo { get; set; }

        public int Count { get; set; }

        public BinCounterDataSet(FbConnection connect, FbCommand command, FbDataAdapter adapter)
            : base(connect, command, adapter)
        {
        }

        public void Select(Int64 testCounterNo, FbTransaction trans = null)
        {
            SetTrans(trans);
            command.CommandText =
                $" select * from TB_BINCOUNTER " +
                $" where fk_testcounterno={testCounterNo} " +
                $" order by fk_binno asc ";

            dataSet.Clear();
            dataAdapter.Fill(dataSet);
        }

        public void Insert(FbTransaction trans = null)
        { 
            string sql =
                $" insert into TB_BINCOUNTER values " +
                $" ({RecNo}, {TestCounterNo}, {BinNo}, {Count}) ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.Parameters.Clear();
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Update(FbTransaction trans = null)
        {
            string sql =
                $" update TB_BINCOUNTER set bincnt={Count} " +
                $" where pk_recno={RecNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.Parameters.Clear();
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Delete(FbTransaction trans = null)
        {
            string sql =
                $" delete from TB_BINCOUNTER where fk_testcounterno={TestCounterNo} ";

            SetTrans(trans);

            try
            {
                BeginTrans(trans);
                command.CommandText = sql;
                command.ExecuteNonQuery();
                CommitTrans(trans);
            }
            catch (Exception e)
            {
                RollbackTrans(trans, e);
            }
        }

        public void Fetch(int index = 0, int tableNo = 0)
        {
            if (index < GetRowCount(tableNo))
            {
                Fetch(dataSet.Tables[tableNo].Rows[index]);
            }
            else
            {
                RecNo = 0;
                TestCounterNo = 0;
                BinNo = 0;
                Count = 0;
            }
        }

        public void Fetch(DataRow row)
        {
            RecNo = Convert.ToInt64(row["pk_recno"]);
            TestCounterNo = Convert.ToInt64(row["fk_testcounterno"]);
            BinNo = Convert.ToInt64(row["fk_binno"]);
            Count = Convert.ToInt32(row["bincnt"]);
        }
    }
}