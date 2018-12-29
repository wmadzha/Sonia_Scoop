// Sample Man Power Management Used In Enterprise Solution

public class ManPower_Controller : ApiController
{
    [HttpGet]    
    public List<string> GetAllRegisteredManpower ()
    {
        // Allowed For Operation Manager/Shift Manager/Assmbly Manager
        // Return All Man Power Involved During Production
       return null;
    }
    [HttpGet]    
    public List<string> GetManPowerPool (string Area)
    {
       // Allowed For Assembly Manager
       // Return All Man Power At A Specific Area 
       return null;
    }
    
    [HttpGet]    
    public List<string> GetManPowerAreaShift (string Area,string Shift)
    {
       // Allowed For Assembly Manager
       // Return All Man Power At A Specific Area Based On Their Shift
       return null;
    }
}
