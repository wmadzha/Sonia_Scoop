// In this demo , we are using example using In Memory Users
public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
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
