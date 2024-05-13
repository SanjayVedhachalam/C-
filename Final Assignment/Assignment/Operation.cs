using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment
{
    public class Operation
    {
        static List<DoctorDetails> doctors = new List<DoctorDetails>();
        static List<PatientDetails> patients = new List<PatientDetails>();
        static List<AppointmentDetails> appointments = new List<AppointmentDetails>();
        static PatientDetails currentLoggedPatient;
        public static void MainMenu()
        {
            string option;
            string wish = "yes";
            do{
                System.Console.WriteLine("Welcome to Doctor - Patient Appointment Booking");
                System.Console.WriteLine("Enter your option");
                System.Console.WriteLine("1. Login\n2. Register\n3. Exit");
                System.Console.Write("Option: ");
                option = Console.ReadLine().ToLower();
                switch(option){
                    case "1":{
                        Login();
                        break;
                    }
                    case "2":{
                        Registration();
                        break;
                    }
                    case "3":{
                        System.Console.WriteLine("Exitting application. Thank you");
                        wish = "no";
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Invalid option. Please choose the correct one");
                        break;
                    }
                }
                
            }while(wish!="no");
        }

        public static void Registration()
        {
            System.Console.WriteLine("Patient Registration Process");
            System.Console.WriteLine("---------------------------------------");

            System.Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            
            System.Console.Write("Enter Patient Age: ");
            int age = int.Parse(Console.ReadLine());

            System.Console.Write("Enter Patient Gender: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);

            PatientDetails patient = new PatientDetails(password, name, age, gender);
            patients.Add(patient);
            System.Console.WriteLine("Registration Successful");
        }
        public static void Login()
        {
            System.Console.WriteLine("Patient Login");
            System.Console.WriteLine("---------------------------------------");
            System.Console.Write("Enter Patient UserName: ");
            string UserName = Console.ReadLine();
            
            System.Console.Write("Enter Password: ");
            string Password = Console.ReadLine();

            bool flag = false;
            foreach (PatientDetails patient in patients)
            {
                if(patient.PatientName.Equals(UserName) && patient.PatientPassword.Equals(Password)){
                    flag = true;
                    currentLoggedPatient = patient;
                    PatientMenu();
                }
            }
            if(flag.Equals(false)){
                System.Console.WriteLine("Sorry, your record is invalid. Please register your profile and log in again.");
            }

        }

        public static void PatientMenu()
        {
            string wish = "yes";
            do{
            System.Console.WriteLine("Patient Menu");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("1. Book Appointment\n2. View Appointment details\n3. Edit my profile\n4. Display profile\n5. Exit");
            System.Console.Write("Enter your option: ");
            string patientMenuOption = Console.ReadLine();
            switch(patientMenuOption){
                case "1":{
                    BookAppointment();
                    break;
                }
                case "2":{
                    ViewAppointmentDetails();
                    break;
                }
                case "3":{
                    EditMyProfile();
                    break;
                }
                case "4":{
                    DisplayProfile();
                    break;
                }
                case "5":{
                    System.Console.WriteLine("Exitting Patient Menu");
                    wish = "no";
                    break;
                }
            }
            }while(wish != "no");
        }


        public static void BookAppointment()
        {
            string bookingOption;
            do{
                System.Console.WriteLine("Appointment Booking");
                System.Console.WriteLine("---------------------------------------");
                System.Console.WriteLine("Select the department from the below list: ");
                System.Console.WriteLine("1. Anaesthesiology\n2. Cardiology\n3. Diabetology\n4. Neonatology\n5. Nephrology\n6. Exit");
                System.Console.Write("Your Department to book appointment: ");
                bookingOption = Console.ReadLine();
                switch(bookingOption){
                    case "1":{
                        Anaesthesiology();
                        break;
                    }
                    case "2":{
                        Cardiology();
                        break;
                    }
                    case "3":{
                        Diabetology();
                        break;
                    }
                    case "4":{
                        Neonatology();
                        break;
                    }
                    case "5":{
                        Nephrology();
                        break;
                    }
                    case "6":{
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Invalid department selected. Try again");
                        break;
                    }
                }
                

                void Anaesthesiology()
                {
                    System.Console.WriteLine("Anaesthesiology Department");
                    System.Console.Write("Enter the problem: ");
                    string problem = Console.ReadLine();
                    System.Console.Write("Enter appointment date in [dd/MM/yyyy] format: ");
                    DateTime appointmentDate;
                    bool appointmentDateCondition = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out appointmentDate);
                    while(!appointmentDateCondition){
                        System.Console.WriteLine("Invalid Date format. Try again");
                        appointmentDateCondition = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out appointmentDate);
                    }
                    int appointmentCount = 0;

                    foreach (AppointmentDetails appointment in appointments)
                    {
                          
                            if(appointmentDate == appointment.AppointmentDate && int.Parse(bookingOption) == appointment.DoctorID && appointment.AppointmentDate == appointmentDate){
                                appointmentCount+=1;
                            }
                            if(appointment.PatientID == currentLoggedPatient.PatientID && int.Parse(bookingOption) == appointment.DoctorID && appointment.AppointmentDate == appointmentDate){
                                System.Console.WriteLine("Appointment already booked");
                                return;
                            }
                        
                    }
                    foreach (DoctorDetails doctor1 in doctors)
                    {
                        if(doctor1.DoctorID == int.Parse(bookingOption)){
                            if(appointmentCount<2){
                                AppointmentDetails appointment = new AppointmentDetails(currentLoggedPatient.PatientID, doctor1.DoctorID, appointmentDate, problem);
                                appointments.Add(appointment);
                                System.Console.WriteLine("Appointment Booked Successfully");
                                appointmentCount = 0;
                                bookingOption = "6";
                            }
                            else{
                                System.Console.WriteLine("The doctor appointment is full. Please select a different date.");
                            }
                        }
                    }
                }

                void Cardiology(){
                    System.Console.WriteLine("Cardiology Department");
                    System.Console.Write("Enter the problem: ");
                    string problem = Console.ReadLine();
                    System.Console.Write("Enter appointment date in [dd/MM/yyyy] format: ");
                    DateTime appointmentDate;
                    bool appointmentDateCondition = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out appointmentDate);
                    while(!appointmentDateCondition){
                        System.Console.WriteLine("Invalid Date format. Try again");
                        appointmentDateCondition = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out appointmentDate);
                    }
                    int appointmentCount = 0;

                    foreach (AppointmentDetails appointment in appointments)
                    {
                          
                            if(appointmentDate == appointment.AppointmentDate && int.Parse(bookingOption) == appointment.DoctorID && appointment.AppointmentDate == appointmentDate){
                                appointmentCount+=1;
                            }
                            if(appointment.PatientID == currentLoggedPatient.PatientID && int.Parse(bookingOption) == appointment.DoctorID && appointment.AppointmentDate == appointmentDate){
                                System.Console.WriteLine("Appointment already booked");
                                return;
                            }
                        
                    }
                    foreach (DoctorDetails doctor1 in doctors)
                    {
                        if(doctor1.DoctorID == int.Parse(bookingOption)){
                            if(appointmentCount<2){
                                AppointmentDetails appointment = new AppointmentDetails(currentLoggedPatient.PatientID, doctor1.DoctorID, appointmentDate, problem);
                                appointments.Add(appointment);
                                System.Console.WriteLine("Appointment Booked Successfully");
                                appointmentCount = 0;
                                bookingOption = "6";
                            }
                            else{
                                System.Console.WriteLine("The doctor appointment is full. Please select a different date.");
                            }
                        }
                    }
                }
            
                void Diabetology(){
                    System.Console.WriteLine("Diabetology Department");
                    System.Console.Write("Enter the problem: ");
                    string problem = Console.ReadLine();
                    System.Console.Write("Enter appointment date in [dd/MM/yyyy] format: ");
                    DateTime appointmentDate;
                    bool appointmentDateCondition = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out appointmentDate);
                    while(!appointmentDateCondition){
                        System.Console.WriteLine("Invalid Date format. Try again");
                        appointmentDateCondition = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out appointmentDate);
                    }
                    int appointmentCount = 0;

                    foreach (AppointmentDetails appointment in appointments)
                    {
                          
                            if(appointmentDate == appointment.AppointmentDate && int.Parse(bookingOption) == appointment.DoctorID && appointment.AppointmentDate == appointmentDate){
                                appointmentCount+=1;
                            }
                            if(appointment.PatientID == currentLoggedPatient.PatientID && int.Parse(bookingOption) == appointment.DoctorID && appointment.AppointmentDate == appointmentDate){
                                System.Console.WriteLine("Appointment already booked");
                                return;
                            }
                        
                    }
                    foreach (DoctorDetails doctor1 in doctors)
                    {
                        if(doctor1.DoctorID == int.Parse(bookingOption)){
                            if(appointmentCount<2){
                                AppointmentDetails appointment = new AppointmentDetails(currentLoggedPatient.PatientID, doctor1.DoctorID, appointmentDate, problem);
                                appointments.Add(appointment);
                                System.Console.WriteLine("Appointment Booked Successfully");
                                appointmentCount = 0;
                                bookingOption = "6";
                            }
                            else{
                                System.Console.WriteLine("The doctor appointment is full. Please select a different date.");
                            }
                        }
                    }
                }
            
                void Neonatology(){
                    System.Console.WriteLine("Neonatology Department");
                    System.Console.Write("Enter the problem: ");
                    string problem = Console.ReadLine();
                    System.Console.Write("Enter appointment date in [dd/MM/yyyy] format: ");
                    DateTime appointmentDate;
                    bool appointmentDateCondition = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out appointmentDate);
                    while(!appointmentDateCondition){
                        System.Console.WriteLine("Invalid Date format. Try again");
                        appointmentDateCondition = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out appointmentDate);
                    }
                    int appointmentCount = 0;

                    foreach (AppointmentDetails appointment in appointments)
                    {
                          
                            if(appointmentDate == appointment.AppointmentDate && int.Parse(bookingOption) == appointment.DoctorID && appointment.AppointmentDate == appointmentDate){
                                appointmentCount+=1;
                            }
                            if(appointment.PatientID == currentLoggedPatient.PatientID && int.Parse(bookingOption) == appointment.DoctorID && appointment.AppointmentDate == appointmentDate){
                                System.Console.WriteLine("Appointment already booked");
                                return;
                            }
                        
                    }
                    foreach (DoctorDetails doctor1 in doctors)
                    {
                        if(doctor1.DoctorID == int.Parse(bookingOption)){
                            if(appointmentCount<2){
                                AppointmentDetails appointment = new AppointmentDetails(currentLoggedPatient.PatientID, doctor1.DoctorID, appointmentDate, problem);
                                appointments.Add(appointment);
                                System.Console.WriteLine("Appointment Booked Successfully");
                                appointmentCount = 0;
                                bookingOption = "6";
                            }
                            else{
                                System.Console.WriteLine("The doctor appointment is full. Please select a different date.");
                            }
                        }
                    }
                }

                void Nephrology(){
                    System.Console.WriteLine("Nephrology Department");
                    System.Console.Write("Enter the problem: ");
                    string problem = Console.ReadLine();
                    System.Console.Write("Enter appointment date in [dd/MM/yyyy] format: ");
                    DateTime appointmentDate;
                    bool appointmentDateCondition = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out appointmentDate);
                    while(!appointmentDateCondition){
                        System.Console.WriteLine("Invalid Date format. Try again");
                        appointmentDateCondition = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out appointmentDate);
                    }
                    int appointmentCount = 0;

                    foreach (AppointmentDetails appointment in appointments)
                    {
                          
                            if(appointmentDate == appointment.AppointmentDate && int.Parse(bookingOption) == appointment.DoctorID && appointment.AppointmentDate == appointmentDate){
                                appointmentCount+=1;
                            }
                            if(appointment.PatientID == currentLoggedPatient.PatientID && int.Parse(bookingOption) == appointment.DoctorID && appointment.AppointmentDate == appointmentDate){
                                System.Console.WriteLine("Appointment already booked");
                                return;
                            }
                        
                    }
                    foreach (DoctorDetails doctor1 in doctors)
                    {
                        if(doctor1.DoctorID == int.Parse(bookingOption)){
                            if(appointmentCount<2){
                                AppointmentDetails appointment = new AppointmentDetails(currentLoggedPatient.PatientID, doctor1.DoctorID, appointmentDate, problem);
                                appointments.Add(appointment);
                                System.Console.WriteLine("Appointment Booked Successfully");
                                appointmentCount = 0;
                                bookingOption = "6";
                            }
                            else{
                                System.Console.WriteLine("The doctor appointment is full. Please select a different date.");
                            }
                        }
                    }
                }
            }while(bookingOption != "6");
            
        }

        public static void ViewAppointmentDetails()
        {
            System.Console.WriteLine("Appointment Details");
            System.Console.WriteLine("---------------------------------------");
            bool flag = false;
            foreach (AppointmentDetails appointment in appointments)
            {
                if(appointment.PatientID == currentLoggedPatient.PatientID){
                    System.Console.WriteLine("Appointment ID  Patient ID                 Doctor ID                 Date                 Problem");
                    break;
                }
            }
            foreach (AppointmentDetails appointment in appointments)
            {
                if(appointment.PatientID == currentLoggedPatient.PatientID){
                    flag = true;
                    System.Console.WriteLine($"{appointment.AppointmentID}                 {appointment.PatientID}                 {appointment.DoctorID}                 {appointment.AppointmentDate}                 {appointment.Problem}");
                }
            }
            if(flag.Equals(false)){
                System.Console.WriteLine("You have no appointments");
            }
        }

        public static void EditMyProfile()
        {
            System.Console.WriteLine("Edit Patient Profile");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("What do you want to edit?");
            System.Console.WriteLine("1. Name\n2. Password\n3. Age\n4. Gender\n5. All");
            System.Console.Write("Your option: ");
            string editOption = Console.ReadLine();

            switch(editOption){
                case "1":{
                    System.Console.Write("Enter new name: ");
                    string newName = Console.ReadLine();
                    currentLoggedPatient.PatientName = newName;
                    System.Console.WriteLine("Editted Name Successfully");
                    break;
                }
                case "2":{
                    System.Console.Write("Enter new password: ");
                    string newPassword = Console.ReadLine();
                    currentLoggedPatient.PatientPassword = newPassword;
                    System.Console.WriteLine("Editted Password Successfully");
                    break;
                }
                case "3":{
                    System.Console.Write("Enter new age: ");
                    string newAge = Console.ReadLine();
                    currentLoggedPatient.PatientAge = int.Parse(newAge);
                    System.Console.WriteLine("Editted Age Successfully");
                    break;
                }
                case "4":{
                    System.Console.WriteLine("Enter new gender: ");
                    Gender newGender = Enum.Parse<Gender>(Console.ReadLine(),true);
                    currentLoggedPatient.PatientGender = newGender;
                    System.Console.WriteLine("Editted Gender Successfully");
                    break;
                }
                case "5":{
                    System.Console.Write("Enter new name: ");
                    string newName = Console.ReadLine();
                    currentLoggedPatient.PatientName = newName;

                    System.Console.Write("Enter new password: ");
                    string newPassword = Console.ReadLine();
                    currentLoggedPatient.PatientPassword = newPassword;

                    System.Console.Write("Enter new age: ");
                    string newAge = Console.ReadLine();
                    currentLoggedPatient.PatientAge = int.Parse(newAge);
                    
                    System.Console.WriteLine("Enter new gender: ");
                    Gender newGender = Enum.Parse<Gender>(Console.ReadLine(),true);
                    currentLoggedPatient.PatientGender = newGender;
                    System.Console.WriteLine("Editted profile successfully");
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid option: Enter a valid one");
                    break;
                }
            }
            
        }
        public static void DisplayProfile()
        {
            System.Console.WriteLine("Profile Details");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine($"Patient ID: {currentLoggedPatient.PatientID}");
            System.Console.WriteLine($"Patient Name: {currentLoggedPatient.PatientName}");
            System.Console.WriteLine($"Patient Age: {currentLoggedPatient.PatientAge}");
            System.Console.WriteLine($"Patient Gender: {currentLoggedPatient.PatientGender}");
        }


        public static void DefaultDetails()
        {
            DoctorDetails doctor1 = new DoctorDetails("Nancy", "Anaesthesiology");
            DoctorDetails doctor2 = new DoctorDetails("Andrew", "Cardiology");
            DoctorDetails doctor3 = new DoctorDetails("Janet", "Diabetology");
            DoctorDetails doctor4 = new DoctorDetails("Margaret", "Neonatology");
            DoctorDetails doctor5 = new DoctorDetails("Steven", "Nephrology");
            doctors.AddRange(new List<DoctorDetails>{doctor1, doctor2, doctor3, doctor4, doctor5});

            PatientDetails patient1 = new PatientDetails("welcome", "Robert", 40, Gender.Male);
            PatientDetails patient2 = new PatientDetails("welcome", "Laura", 36, Gender.Female);
            PatientDetails patient3 = new PatientDetails("welcome", "Anne", 42, Gender.Female);
            patients.AddRange(new List<PatientDetails>{patient1,patient2, patient3});

            AppointmentDetails appointment1 = new AppointmentDetails(1, 2, new DateTime(2012,03,08), "Heart problem");
            AppointmentDetails appointment2 = new AppointmentDetails(1, 5, new DateTime(2012,03,08), "Spinal cord injury");
            AppointmentDetails appointment3 = new AppointmentDetails(2, 2, new DateTime(2012,03,08), "Heart attack");
            appointments.AddRange(new List<AppointmentDetails>{appointment1, appointment2, appointment3});
        }
    }
}