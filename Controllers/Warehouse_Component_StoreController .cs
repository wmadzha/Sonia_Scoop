// Sample Warehouse API Used In Enterprise Solution
public class Warehouse_Component_StoreController : ApiController
{
    [AuthorizeEnterpriseClaim("warehouse_assembly_module", "warehouse_basic")]
    [HttpGet]    
    public List<string> GetAllComponentListItems ()
    {
        // Allowed For Everybody Working In Warehouse
        // Return All Component Or Parts That Is Used In SMT Board/Assemblies/Packaging/Logistic Factory Lines
       return null;
    }
    [AuthorizeEnterpriseClaim("warehouse_assembly_module", "warehouse_smt")]
    [HttpGet]    
    public List<string> GetMountingBoardComponentItems ()
    {
        // Allowed For Everybody Working In SMT Board Mounting Area
        // Return All Component Or Parts That Is Used In SMT Board Mounting Assemblies
       return null;
    }
    [AuthorizeEnterpriseClaim("warehouse_assembly_module", "warehouse_product")]
    [HttpGet]    
    public List<string> GetProductAssembliesComponentItems ()
    {
       // Allowed For Everybody Working In Product Assembly Area
       // Return All Component Or Parts That Is Used In Product Assembly Area
       return null;
    }
    [AuthorizeEnterpriseClaim("warehouse_assembly_module", "warehouse_packaging")]
    [HttpGet]    
    public List<string> GetPackagingWarehouseComponentItems ()
    {
       // Allowed For Everybody Working In Packaging Area
       // Return All Component Or Parts That Is Used In Packaging Area
       return null;
    }
    [AuthorizeEnterpriseClaim("warehouse_assembly_module", "warehouse_basic")]
    [HttpGet]    
    public List<string> GetLogisticComponentItems ()
    {
       // Allowed For Everybody Working In Logistic Area
       // Return All Component Or Parts That Is Used In Logistic Area
       return null;
    }
}
