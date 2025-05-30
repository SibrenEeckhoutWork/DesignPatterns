using observer;

WeatherStation weatherStation = new WeatherStation();

// Maak concrete observers
IObserver display = new TemperatureDisplay();
IObserver alert = new TemperatureAlert();

// Registreer observers bij het weerstation
weatherStation.RegisterObserver(display);
weatherStation.RegisterObserver(alert);

// Simuleer temperatuurveranderingen
weatherStation.SetTemperature(25.0f);  // Normale temperatuur
weatherStation.SetTemperature(35.0f);  // Hoge temperatuur