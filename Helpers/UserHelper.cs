
// In this example we are declaring a static Claims.
public static class HumanResourceClaim
{
    public static Claim HumanResource_Manager()
    {
        return new Claim("humanresource_module", "hr_manager");
    }
    public static Claim HumanResource_Operator()
    {
        return new Claim("humanresource_module", "hr_operator");
    }
    public static Claim HumanResource_Opertation_Manager()
    {
        return new Claim("humanresource_module", "operation_manager");
    }
    public static Claim HumanResource_Shift_Manager()
    {
        return new Claim("humanresource_module", "shift_manager");
    }

}
public static class SMTAssemblyModuleClaim
{
    public static Claim SMTModule_Basic()
    {
        return new Claim("smt_assembly_module", "assembly_basic_user");
    }
    public static Claim SMTModule_Manager()
    {
        return new Claim("smt_assembly_module", "assembly_manager");
    }

}
public static class ProductAssemblyModuleClaim
{
    public static Claim ProductAssemblyModule_Basic()
    {
        return new Claim("product_assembly_module", "assembly_basic_user");
    }
    public static Claim ProductAssemblyModule_Manager()
    {
        return new Claim("product_assembly_module", "assembly_manager");
    }
}
public static class WarehouseAssemblyModuleClaim
{
    public static Claim WarehouseAssemblyModule_Basic()
    {
        return new Claim("warehouse_assembly_module", "warehouse_basic");
    }
    public static Claim WarehouseAssemblyModule_SMT()
    {
        return new Claim("warehouse_assembly_module", "warehouse_smt");
    }
    public static Claim WarehouseAssemblyModule_Product()
    {
        return new Claim("warehouse_assembly_module", "warehouse_product");
    }
    public static Claim WarehouseAssemblyModule_Packaging()
    {
        return new Claim("warehouse_assembly_module", "warehouse_packaging");
    }
}
