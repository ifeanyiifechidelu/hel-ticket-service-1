namespace Hel_Ticket_Service.Domain;

public static class MessageProvider
{
    public const string MongoDBDown = "MongoDB Server is down";
    public const string RedisDBDown = "Redis Server is down";

    public const string CategoryNotFound = "Category Not Found";
    public const string CategoryAlreadyExists = "Category Already Exists";
    public const string CategoryEmailAlreadyExists = "Category Email Already Exists";
    public const string CategoryCredentialInvalid  ="Invalid Credentials. Please stand advised";
    public const string InvalidParameters  ="Parameters must be in the required format and must not be null. Please stand advised.";
    public const string CategoryNameNull = "Categoryname must not be empty. Please stand advised.";
    public const string PasswordNull = "Password must not be empty. Please stand advised.";


}