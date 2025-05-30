using bridge;

Implementor box = new Box();
Implementor stereo = new Stereo();

Controller simpleControllerBox = new SimpleController(box);
Controller simpleControllerStereo = new SimpleController(stereo);
AdvancedController advancedControllerStereo = new AdvancedController(stereo);
Controller advancedControllerBox = new AdvancedController(box);

simpleControllerBox.setVolume(50);
simpleControllerStereo.setVolume(20);

advancedControllerBox.setVolume(50);
advancedControllerStereo.setVolume(20);

simpleControllerBox.playMusic();
simpleControllerStereo.playMusic();

advancedControllerBox.playMusic();
advancedControllerStereo.playMusic();

advancedControllerStereo.mute();