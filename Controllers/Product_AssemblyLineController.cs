// Sample Product Assemblies Line Used In Enterprise Solution

public class Product_AssemblyLineController : ApiController
{
    [HttpGet]    
    public List<string> GetRunningProductAssemblyLine (string Date )
    {
        // Allowed For Everybody Working In Product Assembly Line
        // Return Production Line Running At a Specific Date
       return null;
    }
    [HttpGet]    
    public List<string> GetAssemblyProductionModelLine (string Date , string ModelCodeName)
    {
        // Allowed For Everybody Working In Product Assembly Line
        // Return Production Line Involve in Assembling A Specific Model At a Specific Date
       return null;
    }
    [HttpGet]    
    public List<string> GetProductionLineOutput (string Date , string ProductionLine)
    {
       // Allowed For Team Leader Working In Product Assembly Line
       // Return Product Serial Number For A Specific Product Assembled In A Particular Production Line
       return null;
    }
    
   
}
