// Sample Man Power Management Used In Enterprise Solution

public class ManPower_Controller : ApiController
{
   
    [AuthorizeEnterpriseClaim("humanresource_module", "hr_manager")]
    [HttpGet]    
    public List<string> GetAllRegisteredManpower ()
    {
        // HR Manager
        // Return All Man Power Involved During Production
       return null;
    }
    [AuthorizeEnterpriseClaim("humanresource_module", "operation_manager")]
    [HttpGet]    
    public List<string> GetManPowerPool (string Area)
    {
       // Allowed For Assembly Manager
       // Return All Man Power At A Specific Area 
       return null;
    }
    [AuthorizeEnterpriseClaim("humanresource_module", "shift_manager")]
    [HttpGet]    
    public List<string> GetManPowerAreaShift (string Area,string Shift)
    {
       // Allowed For Assembly Manager
       // Return All Man Power At A Specific Area Based On Their Shift
       return null;
    }
}
