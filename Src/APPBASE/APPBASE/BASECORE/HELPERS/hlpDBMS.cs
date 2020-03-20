using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Sql;
using System.Data.SqlClient;
using APPBASE.Helpers;

namespace APPBASE.Helpers
{
    public class hlpDBMS
    {
        #region Initialize
            public string DBStrConn, DBType, DBServer, DBName, DBUser, DBPassword;
            public const string DBMSSQL = "MSSQL";
            public const string DBMYSQL = "MYSQL";
            public const string DBNOSQL = "NOSQL";
            public const string DBORCL = "ORCLE";
            public const string DBFOX = "FOXDB";
            public const string DBFBD = "FRBRD";
        #endregion
        
        #region Constructor
            //Constructor 1
            public hlpDBMS()
            {
                //TODO: Need to be refactor base on design pattern
                string vsDBNO = Properties.Settings.Default.DBPASSWORD;
                if (vsDBNO == "1") { useDatabase01(); } //End if (vsDBNO == "1")
                if (vsDBNO == "2") { useDatabase02(); } //End if (vsDBNO == "2")
                setStrConn();
            } //End constructor 1 - hlpDBMS()
            //Constructor 2
            public hlpDBMS(int pnDBNO)
            {
                //TODO: Need to be refactor base on design pattern
                string vsDBNO = pnDBNO.ToString();
                if (vsDBNO == "1") { useDatabase01(); } //End if (vsDBNO == "1")
                if (vsDBNO == "2") { useDatabase02(); } //End if (vsDBNO == "2")
                setStrConn();
            } //End constructor 1 - hlpDBMS(string psDBNO)
        #endregion
        
        #region Private static method Database 01 Information
            //TODO: Need to be refactor base on design pattern

            private static string getDB01TYPE()
            {
                return Properties.Settings.Default.DBTYPE.ToString();
            } //End method

            private static string getDB01SERVER()
            {
                return Properties.Settings.Default.DBSERVER.ToString();
        } //End method

            private static string getDB01NAME()
                {
                    return Properties.Settings.Default.DBNAME.ToString();
            } //End method

            private static string getDB01USERID()
                {
                    return Properties.Settings.Default.DBUSERID.ToString();
            } //End method

            private static string getDB01PASSWORD()
                {
                    return Properties.Settings.Default.DBPASSWORD.ToString();
            } //End method

        #endregion

        #region Private static method Database 02 For Encrypted Information
            //TODO: Need to be refactor base on design pattern

            private static string getDB02TYPE()
            {
                return hlpObf.randomDecrypt(Properties.Settings.Default.DBTYPE.ToString());
            } //End private static string getDB02TYPE()

            private static string getDB02SERVER()
            {
                return hlpObf.randomDecrypt(Properties.Settings.Default.DBSERVER.ToString());
            } //End private static string getDB02SERVER()

            private static string getDB02NAME()
            {
                return hlpObf.randomDecrypt(Properties.Settings.Default.DBNAME.ToString());
            } //End private static string getDB02NAME()

            private static string getDB02USERID()
            {
                return hlpObf.randomDecrypt(Properties.Settings.Default.DBUSERID.ToString());
            } //End private static string getDB02USERID()

            private static string getDB02PASSWORD()
            {
                return hlpObf.randomDecrypt(Properties.Settings.Default.DBPASSWORD.ToString());
            } //End private static string getDB02PASSWORD()

        #endregion

        #region Private method Using Database

            //Using 1st database
            private void useDatabase01()
            {
                DBType = getDB01TYPE();
                DBServer = getDB01SERVER();
                DBName = getDB01NAME();
                DBUser = getDB01USERID();
                DBPassword = getDB01PASSWORD();
            } //End method

            //Using 2nd database
            private void useDatabase02()
            {
                DBType = getDB02TYPE();
                DBServer = getDB02SERVER();
                DBName = getDB02NAME();
                DBUser = getDB02USERID();
                DBPassword = getDB02PASSWORD();
            } //End method

        #endregion

        //Set Connection string
        private void setStrConn()
        {
            DBStrConn = "";
            //MSSQL Connection string
            if (DBType == DBMSSQL)
            {
                //@"Data Source=localhost;Initial Catalog=DBMAIN;Integrated Security=False;User Id=sa;Password=Rahasia123.;MultipleActiveResultSets=True"
                DBStrConn = @"Data Source=" + DBServer +
                ";Initial Catalog=" + DBName +
                ";Integrated Security=False;User Id=" + DBUser +
                ";Password=" + DBPassword +
                ";MultipleActiveResultSets=True";
            } //End if (psDBType == DBMSSQL)
              //MYSQL Connection
            if (DBType == DBMYSQL) { DBStrConn = ""; } //End if (psDBType == DBMYSQL)
                                                       //NOSQL Connection
            if (DBType == DBNOSQL) { DBStrConn = ""; } //End if (psDBType == DBNOSQL)
                                                       //ORCLE Connection
            if (DBType == DBORCL) { DBStrConn = ""; } //End if (psDBType == DBORCL)
                                                      //FOXDB Connection
            if (DBType == DBFOX) { DBStrConn = ""; } //End if (psDBType == DBFOX)
                                                     //FRBRD Connection
            if (DBType == DBFBD) { DBStrConn = ""; } //End if (psDBType == DBFBD)
        } //End method

        public static string getStrConn()
        {
            string vsDBNO = Properties.Settings.Default.DBNO;
            //string stemp = getStrConn(Convert.ToInt32(vsDBNO));
            return getStrConn(Convert.ToInt32(vsDBNO));
        } //End method

        public static string getStrConn(int pnDBNO)
        {
            string vsDBNO = pnDBNO.ToString();
            string vsDBType = "";
            string vsDBServer = "";
            string vsDBName = "";
            string vsDBUser = "";
            string vsDBPassword = "";

            //Plain text setting
            if (vsDBNO == "1")
            {
                vsDBType = getDB01TYPE();
                vsDBServer = getDB01SERVER();
                vsDBName = getDB01NAME();
                vsDBUser = getDB01USERID();
                vsDBPassword = getDB01PASSWORD();
            } //End if

            //Encryptred setting
            if (vsDBNO == "2")
            {
                vsDBType = getDB02TYPE();
                vsDBServer = getDB02SERVER();
                vsDBName = getDB02NAME();
                vsDBUser = getDB02USERID();
                vsDBPassword = getDB02PASSWORD();
            } //End if

            string vReturn = @"Data Source=" + vsDBServer +
            ";Initial Catalog=" + vsDBName +
            ";Integrated Security=False;User Id=" + vsDBUser +
            ";Password=" + vsDBPassword +
            ";MultipleActiveResultSets=True";
            return vReturn;
        } //End method


    } //End class

} //End namespace