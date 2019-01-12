// In this code we are demonstrating using in memory user
public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "alice",
                    Password = "password",

                    Claims = new []
                    {
                        // Best practice is to encrypt the value of claim, and decrypt at the microservices end
                        new Claim("accounting_module","invoice_creator"),
                        new Claim("accounting_module","receipt_handler,invoice_viewer"),
                        new Claim("accounting_module","invoice_viewer"),
                        new Claim("humanresource_module","basic_user"),
                        new Claim("warehouse_module","not_authorized"),
                        new Claim("marketing_module","not_authorized"),
                    }
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "bob",
                    Password = "password",

                    Claims = new []
                    {
                         // Best practice is to encrypt the value of claim, and decrypt at the microservices end
                        new Claim("accounting_module","not_authorized"),
                        new Claim("humanresource_module","basic_user,admin_user,approve_application,approve_employee_claim"),
                        new Claim("warehouse_module","not_authorized"),
                        new Claim("marketing_module","not_authorized"),
                    }
                    
                },
                new TestUser
                {
                    SubjectId = "3",
                    Username = "sally",
                    Password = "password",

                    Claims = new []
                    {
                        // Best practice is to encrypt the value of claim, and decrypt at the microservices end
                        new Claim("accounting_module","not_authorized"),
                        new Claim("humanresource_module","basic_user"),
                        new Claim("warehouse_module","inventory_admin,procument_manager"),
                        new Claim("marketing_module","invoice_issuer"),
                    }

                },
                new TestUser
                {
                    SubjectId = "4",
                    Username = "tatianna",
                    Password = "password",

                    Claims = new []
                    {
                        // Best practice is to encrypt the value of claim, and decrypt at the microservices end
                        new Claim("accounting_module","not_authorized"),
                        new Claim("humanresource_module","basic_user"),
                        new Claim("warehouse_module","not_authorized"),
                        new Claim("marketing_module","invoice_issuer,sales_admin"),
                    }

                },

                new TestUser
                {
                    SubjectId = "ENT-1",
                    Username = "Marianne",
                    Password = "password",
                    
                    Claims = new []
                    {
                        HumanResourceClaim.HumanResource_Operator(),
                        HumanResourceClaim.HumanResource_Manager(),

                    }
                },

                new TestUser
                {
                    SubjectId = "ENT-2",
                    Username = "Lucy",
                    Password = "password",

                    Claims = new []
                    {
                        SMTAssemblyModuleClaim.SMTModule_Basic(),
                        HumanResourceClaim.HumanResource_Operator(),
                    }
                },
                 new TestUser
                {
                    SubjectId = "ENT-3",
                    Username = "Adrianne",
                    Password = "password",

                    Claims = new []
                    {
                        WarehouseAssemblyModuleClaim.WarehouseAssemblyModule_Product(),
                        ProductAssemblyModuleClaim.ProductAssemblyModule_Manager(),
                        HumanResourceClaim.HumanResource_Operator(),
                    }
                },
                  new TestUser
                {
                    SubjectId = "ENT-4",
                    Username = "Tatianna",
                    Password = "password",

                    Claims = new []
                    {
                        WarehouseAssemblyModuleClaim.WarehouseAssemblyModule_Basic(),
                        HumanResourceClaim.HumanResource_Operator(),
                    }
                },
                   new TestUser
                {
                    SubjectId = "ENT-5",
                    Username = "Tania",
                    Password = "password",

                    Claims = new []
                    {
                        SMTAssemblyModuleClaim.SMTModule_Manager(),
                        WarehouseAssemblyModuleClaim.WarehouseAssemblyModule_SMT(),
                        HumanResourceClaim.HumanResource_Manager(),
                    }
                }
            };
        }
