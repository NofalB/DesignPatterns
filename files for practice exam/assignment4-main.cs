    static void Main(string[] args)
    {
      // create solarpanel system
      IObservable systeem = new SolarPanelSystem();

      // create a controller
      // TODO...

      // create a solarpanel display
	  // TODO...

      // perform a few measurements
      for (int i = 0; i < 10; i++)
        controller.NewMeasurement();

      Console.ReadKey();
    }
