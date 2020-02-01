using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airport
{
    public class StoredProcedures
    {
        public static string GetFlightDetailsPNR = "GetFlightDetailsPNR";
        public static string AirportEmpLogin = "AirportLoginVerify";
        public static string GetEmployeeByIDAirport = "SelectEmployeeByIdAirport";
        public static string GetAllFlights = "LoadFlightsAirport";
        public static string SearchFLightNo = "SelectFlightByFlightNoAirport";
        public static string UpdateFlight = "UpdateFlightAirport";
        public static string AddEmployeeAirline = "AddEmployeeAirline";
        public static string AddFlightAirport = "AddFlightAirport";
        public static string AirlineLoginVerify = "AirlineLoginVerify";
        public static string BanPassenger = "BanPassenger";
        public static string CheckForFlightExistenceAirport = "ChechForFlightExistenceAirport";
        public static string DeleteFlightAirport = "DeleteFlightAirport";
        public static string GovLoginVerify = "GovLoginVerify";
        public static string LoadEmployeesAirport = "LoadEmployeesAirport";
        public static string LoadPassengersAirport = "LoadPassengersAirport";
        public static string RemoveAirlineEmployees = "RemoveAirlineEmployees";
        public static string SearchFlightAirport = "SearchFlightAirport";
        public static string SearchPassengerByCityAirport = "SearchPassengerByCityAirport";
        public static string SearchPassengerByFlight = "SearchPassengerByFlight";
        public static string SearchPassengerByNameAirport = "SearchPassengerByNameAirport";
        public static string SearchPassengerByPassport = "SearchPassengerByPassport";
        public static string SelectBanned = "SelectBanned";
        public static string SelectEmployeeByAirline = "SelectEmployeeByAirline";
        public static string SelectEmployeeByIdAirline = "SelectEmployeeByIdAirline";
        public static string SelectFlightByAirline = "SelectFlightByAirline";
        public static string SelectPassengerByAirline = "SelectPassengerByAirline";
        public static string UnbanPassenger = "UnbanPassenger";
        public static string UpdateEmployeeAirline = "UpdateEmployeeAirline";
        public static string UpdateEmployeeAirport = "UpdateEmployeeAirport";
        public static string UpdateFlightAiport = "UpdateFlightAiport";
        public static string SearchFlightByCity = "SearchFlightByCityAirport";
        public static string SearchFlightByDate = "SearchFlightByDate";
        public static string ChangePasswordAirportEmployee = "ChangePasswordAirportEmployee";
        public static string ChangePasswordAirlineEmployee = "ChangePasswordAirlineEmployee";
        public static string ChangePasswordGovEmployee = "ChangePasswordGovEmployee";
        public static string GetPasswordAirportEmployee = "GetPasswordAirportEmployee";
        public static string GetPasswordAirlineEmployee = "GetPasswordAirlineEmployee";
        public static string GetPasswordGovEmployee = "GetPasswordGovEmployee";
        public static string GetGovEmployeeName = "GetGovEmployeeName";
        public static string GetAirlineCity = "GetAirlineCity";
        public static string GetCityAirline = "GetCityAirline";
    }
}
