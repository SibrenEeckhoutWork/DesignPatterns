using facade;

ISmartHomeFacade smartHome = new SmartHomeFacade(new Thermostat(), new Light("living"), new SecuritySystem(), new MusicSystem());

smartHome.WegModus();

smartHome.ThuisModus();