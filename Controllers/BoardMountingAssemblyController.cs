public class PCB_Mounting_AssemblyController : ApiController
{
    [HttpGet]    
    public List<string> GetOnlineMountingMachine (string Date)
    {
        // Allowed For Everybody Working In Assembly Area
        // Return SMT Machine Running At A Specific Date
       return null;
    }
    [HttpGet]    
    public List<string> GetMachineOutput (string Date , string SMTMachineName)
    {
       // Allowed For Everybody Working In Assembly Area
       // Return PCB Board Ouput Serial Number Of A Specific Date Of A Particular SMT Machine 
       return null;
    }
    
    [HttpGet]    
    public List<string> GetMachineOperators (string Date , string SMTMachineName)
    {
       // Allowed Only For Assembly Manager
       // Return Individual Resonsible For The SMT Machine During Specific Date
       return null;
    }
}