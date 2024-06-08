using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Police.BLL
{
    enum FormStatus { add, update};
    public static class MyDb
    {
        public static CitiesTable City = new CitiesTable();
        public static ActualSecuritryTable ActualSecuritry = new ActualSecuritryTable();
        public static ActualRescueTable ActualRescue = new ActualRescueTable();
        public static ChangeReportStatusTable ChangeReportStatus = new ChangeReportStatusTable();
        public static OpeningComplaintsTable OpeningComplaints = new OpeningComplaintsTable();
        public static PeopleAreHurtingTable PeopleAreHurting = new PeopleAreHurtingTable();
        public static PolicemanTable Policeman = new PolicemanTable();
        public static PolicemanInSafetyTable PolicemanInSafety = new PolicemanInSafetyTable();
        public static PoliceSecretaryTable PoliceSecretary = new PoliceSecretaryTable();
        public static ReportListStatusTable ReportListStatus = new ReportListStatusTable();
        public static RescuersTable Rescuers = new RescuersTable();
        public static SecurityPortfolioStatusTable SecurityPortfolioStatus = new SecurityPortfolioStatusTable();
        public static TrafficReportsTable TrafficReports = new TrafficReportsTable();
        public static TypesOfPoliceTable TypesOfPolice = new TypesOfPoliceTable();
        public static TypesOfReportsTable TypesOfReports = new TypesOfReportsTable();
        public static TypesOfRescueTable TypesOfRescue = new TypesOfRescueTable();
        public static TypesOfSecurityTable TypesOfSecurity = new TypesOfSecurityTable();
        public static MenTable Man = new MenTable();

    }
}
