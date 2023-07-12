﻿namespace Server.Data.Common.Constants;

public static class ExceptionMessages
{
    public const string PropertyNotFound = "Property with id {0} is not found.";

    public const string PostNotFound = "Post with id {0} is not found.";

    public const string PropertiesNotFound = "Properties is not found.";

    public const string PostsNotFound = "Posts is not found.";

    public const string IdIsNull = "Id is not found.";

    public const string UserNotFound = "Unable to load user with ID '{0}'.";

    public const string UsersNotFound = "No users found.";

    public const string InvalidOperation = "Invalid Operation!";

    public const string InvalidLogin = "Invalid login attempt!";

    public const string AddPropertyToCollectionNotFound = "This property is already in your collection.";

    public const string SuccessfulRecord = "Successfully updated User.";

    public const string ErrorMessage = "ErrorMessage";

    public const string SuccessMessage = "SuccessMessage";

    public const string UserMessage = "Successfully deleted user";

    public const string InvalidMessage = "User can not deleted";

    public const string ContentMessage = "Content is null";

    public const string LoggerMessage = "Something went wrong: {ex}";
}