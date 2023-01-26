namespace Hel_Ticket_Service.Domain;

public static class ConstProvider
{
    public const string SerilogOutPutTemplate = "{{\"@timestamp\": \"{Timestamp:u}\", " +
                 "\"level\": \"[{Level}]\", \"status_code\": {StatusCode},  \"message\": \"{Message:lj}\"," + 
                 "\"time_elapsed\": {Elapsed}, \"source\": \"{SourceContext}\"," + 
                 "\"logger_name\": \"Serilog\", \"app_name\": \"{ApplicationName}\", \"version\": \"{Version}\", " + 
                 "\"request_method\": \"{RequestMethod}\", \"request_path\": \"{RequestPath}\"," + 
                 "\"x_correlation_id\": \"{CorrelationId}\", \"hel_app_configagent\": \"{ClientAgent}\"," + 
                 "\"client_name\": \"{MachineName}\", \"client_ip\": \"{ClientIp}\"}}{NewLine}";
 

}