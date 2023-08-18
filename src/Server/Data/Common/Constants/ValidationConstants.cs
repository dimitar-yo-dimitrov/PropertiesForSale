﻿namespace Server.Data.Common.Constants;

public class ValidationConstants
{
    public class User
    {
        public const int UserNameMinLength = 1;
        public const int UserNameMaxLength = 50;

        public const int UserFirstNameMinLength = 1;
        public const int UserFirstNameMaxLength = 50;

        public const int UserLastNameMinLength = 5;
        public const int UserLastNameMaxLength = 50;

        public const int EmailMinLength = 10;
        public const int EmailMaxLength = 60;

        public const int PasswordMaxLength = 6;
        public const int PasswordMinLength = 20;

        public const int PhoneNumberMaxLength = 15;

        public const string RegexPhoneNumber = @"^(\d{4})\-?(\d{3})\-?(\d{3})$";
        public const string RegexPhoneNumberError = "Phone Number is not corect!";
    }

    public class Identity
    {
        public const int MinEmailLength = 3;
        public const int MaxEmailLength = 50;
        public const int MinPasswordLength = 6;
        public const string AdministratorRole = "Administrator";
    }

    public class Property
    {
        public const int PropertyMinTitle = 5;
        public const int PropertyMaxTitle = 50;

        public const int OwnerMinLength = 5;
        public const int OwnerMaxLength = 50;

        public const int PropertyMinDescription = 20;
        public const int PropertyMaxDescription = 5000;

        public const int HomeMinAddress = 10;
        public const int HomeMaxAddress = 100;

        public const int MaxUrl = 500;

        public const string PriceMinLength = "0.00";
        public const string PriceMaxLength = "1000000000.00";

        public const string RegexAddress =
            @"^([A-Za-z]+?\s?[A-Za-z]+),\s([A-Za-z]+?\s?[A-Za-z]+),\s([\d]{1,4}),?\s?([\d+]{1,4})?,?\s?([A-Za-z])?,?\s?([\d+]{1,4})?,?\s?([\d+]{1,4})?,\s([\d]{4,4})$";
        public const string RegexAddressError = "Enter address in the format: City, street, number, block, entrance, floor, apartment, postal code";

        public const string SquareMetersMin = "1.00";
        public const string SquareMetersMax = "100000.00";
    }

    public class City
    {
        public const int CityMinName = 2;
        public const int CityMaxName = 50;
    }

    public class Comment
    {
        public const int MassageMin = 2;
        public const int MassageMax = 2000;

        public const int SenderMinLength = 5;
        public const int SenderMaxLength = 50;
    }

    public class FormattingConstant
    {
        public const string DateFormat = "{0:dd.MM.yyyy}";
    }
    public class AdminConstants
    {
        public const string AdministratorRoleName = "Admin";
        public const string OwnerRoleName = "Owner";
        public const string UserRoleName = "User";

        public const string AdminAreaName = "Admin";
    }

    public class MyLogEvents
    {
        public const int GenerateItems = 1000;
        public const int ListItems = 1001;
        public const int GetId = 1002;
        public const int InsertItem = 1003;
        public const int UpdateItem = 1004;
        public const int DeleteItem = 1005;

        public const int TestItem = 3000;

        public const int GetItemNotFound = 4000;
        public const int UpdateItemNotFound = 4001;
    }
}