using Domain;


// Using CombustionEngine Class
CombustionEngine combustionEngine= new CombustionEngine();

Car ferrari = new Car(combustionEngine);
ferrari.Start();

// Abstract class has a abstract function Start AC which is protected 
// and it is not accessible from another assembly or its object 
// combustionEngine.StartAC();


// Using ElectrictEngine Class
ElectricEngine electricEngine= new ElectricEngine();
Car tesla = new Car(electricEngine);
tesla.Start();
