using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Airport
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


        public DataTable GetFlightDetailsPNR(string PNR, string Surname)
        {

            string StoredProcedureName = StoredProcedures.GetFlightDetailsPNR;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PNR", PNR);
            Parameters.Add("@Surname", Surname);           
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable AirportLoginVerfication(string Username, string Password)
        {

            string StoredProcedureName = StoredProcedures.AirportEmpLogin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable AirportEmpbyID(int ID)
        {

            string StoredProcedureName = StoredProcedures.GetEmployeeByIDAirport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetAllFlightData()
        {
            string StoredProcedureName = StoredProcedures.GetAllFlights;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SearchFlightbyNo(string FlightNo)
        {

            string StoredProcedureName = StoredProcedures.SearchFLightNo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FlightNo", FlightNo);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int UpdateFlight(string flightNo, bool arrDep, string time, string city, string airline, string terminal, string runway, string planeType)
        {
            string StoredProcedureName = StoredProcedures.UpdateFlight;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FlightNo", flightNo);
            Parameters.Add("@ArrDep", arrDep);
            Parameters.Add("@Time", time);
            Parameters.Add("@City", city);
            Parameters.Add("@Airline", airline);
            Parameters.Add("@Terminal", terminal);
            Parameters.Add("@Runway", runway);
            Parameters.Add("@PlaneType", planeType);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddEmployeeAirline(int Id, string Lname, string Fname, string JobTitle, string Airline)
        {
            string StoredProcedureName = StoredProcedures.AddEmployeeAirline;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Id", Id);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@JobTitle", JobTitle);
            Parameters.Add("@Airline", Airline);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddFlightAirport(string FlightNo, bool ArrDep, string Time, string City, string Airline, string Terminal, string Runway, string PlaneType)
        {
            string StoredProcedureName = StoredProcedures.AddFlightAirport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FlightNo", FlightNo);
            Parameters.Add("@ArrDep", ArrDep);
            Parameters.Add("@Time", Time);
            Parameters.Add("@City", City);
            Parameters.Add("@Airline", Airline);
            Parameters.Add("@Terminal", Terminal);
            Parameters.Add("@Runway", Runway);
            Parameters.Add("@PlaneType", PlaneType);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object AirlineLoginVerify(string Username, string Password)
        {
            string StoredProcedureName = StoredProcedures.AirlineLoginVerify;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int BanPassenger(string PassportNo)
        {
            string StoredProcedureName = StoredProcedures.BanPassenger;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PassportNo", PassportNo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteFlightAirport(string FlightNo)
        {
            string StoredProcedureName = StoredProcedures.DeleteFlightAirport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FlightNo", FlightNo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int GovLoginVerify(string Username, string Password)
        {
            string StoredProcedureName = StoredProcedures.GovLoginVerify;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable LoadEmployeesAirport()
        {
            string StoredProcedureName = StoredProcedures.LoadEmployeesAirport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable LoadPassengersAirport()
        {
            string StoredProcedureName = StoredProcedures.LoadPassengersAirport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int RemoveAirlineEmployees(int Id)
        {
            string StoredProcedureName = StoredProcedures.RemoveAirlineEmployees;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Id", Id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SearchFlightAirport(string FlightNo)
        {
            string StoredProcedureName = StoredProcedures.SearchFlightAirport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FlightNo", FlightNo);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SearchPassengerByCityAirport(string City)
        {
            string StoredProcedureName = StoredProcedures.SearchPassengerByCityAirport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@City", City);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SearchPassengerByFlight(string FlightNo)
        {
            string StoredProcedureName = StoredProcedures.SearchPassengerByFlight;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FlightNo", FlightNo);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SearchPassengerByNameAirport(string Fname, string Lname)
        {
            string StoredProcedureName = StoredProcedures.SearchPassengerByNameAirport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SearchPassengerByPassport(string PassportNo)
        {
            string StoredProcedureName = StoredProcedures.SearchPassengerByPassport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PassportNo", PassportNo);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectBanned()
        {
            string StoredProcedureName = StoredProcedures.SelectBanned;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectEmployeeByAirline(string Airline)
        {
            string StoredProcedureName = StoredProcedures.SelectEmployeeByAirline;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Airline", Airline);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectEmployeeByIdAirline(int Id)
        {
            string StoredProcedureName = StoredProcedures.SelectEmployeeByIdAirline;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Id", Id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectFlightByAirline(string Airline)
        {
            string StoredProcedureName = StoredProcedures.SelectFlightByAirline;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Airline", Airline);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectPassengerByAirline(string Airline)
        {
            string StoredProcedureName = StoredProcedures.SelectPassengerByAirline;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Airline", Airline);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int UnbanPassenger(string PassportNo)
        {
            string StoredProcedureName = StoredProcedures.UnbanPassenger;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PassportNo", PassportNo);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateEmployeeAirline(int Id, string Lname, string Fname, string JobTitle, string Airline)
        {
            string StoredProcedureName = StoredProcedures.UpdateEmployeeAirline;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Id", Id);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@JobTitle", JobTitle);
            Parameters.Add("@Airline", Airline);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateEmployeeAirport(int Id, string Fname, string Lname, int Salary, string JobTitle, string Department)
        {
            string StoredProcedureName = StoredProcedures.UpdateEmployeeAirport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Id", Id);
            Parameters.Add("@Fname", Fname);
            Parameters.Add("@Lname", Lname);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@JobTitle", JobTitle);
            Parameters.Add("@Department", Department);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateFlightAirport(string FlightNo, bool ArrDep, string Time, string City, string Airline, string Terminal, string Runway, string PlaneType)
        {
            string StoredProcedureName = StoredProcedures.UpdateEmployeeAirline;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@FlightNo", FlightNo);
            Parameters.Add("@ArrDep", ArrDep);
            Parameters.Add("@Time", Time);
            Parameters.Add("@City", City);
            Parameters.Add("@Airline", Airline);
            Parameters.Add("@Terminal", Terminal);
            Parameters.Add("@Runway", Runway);
            Parameters.Add("@PlaneType", PlaneType);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SearchFlightByCity(string City)
        {
            string StoredProcedureName = StoredProcedures.SearchFlightByCity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@City", City);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SearchFlightByDate(string Date)
        {
            string StoredProcedureName = StoredProcedures.SearchFlightByDate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Date", Date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int ChangePasswordAirportEmployee(int Id)
        {
            string StoredProcedureName = StoredProcedures.ChangePasswordAirportEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Id", Id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ChangePasswordAirlineEmployee(int Id)
        {
            string StoredProcedureName = StoredProcedures.ChangePasswordAirlineEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Id", Id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ChangePasswordGovEmployee(int Id)
        {
            string StoredProcedureName = StoredProcedures.ChangePasswordGovEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Id", Id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public string GetPasswordAirportEmployee(int Id)
        {
            string StoredProcedureName = StoredProcedures.GetPasswordAirportEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Id", Id);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public string GetPasswordAirlineEmployee(int Id)
        {
            string StoredProcedureName = StoredProcedures.GetPasswordAirlineEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Id", Id);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public string GetPasswordGovEmployee(int Id)
        {
            string StoredProcedureName = StoredProcedures.GetPasswordGovEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Id", Id);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public string GetGovEmployeeName(int Id)
        {
            string StoredProcedureName = StoredProcedures.GetGovEmployeeName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Id", Id);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }


        public string GetCityForAirline(string Airline)
        {
            string StoredProcedureName = StoredProcedures.GetAirlineCity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Airline", Airline);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public string GetAirlineForCity(string City)
        {
            string StoredProcedureName = StoredProcedures.GetCityAirline;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@City", City);
            return (string)dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
    }
}
