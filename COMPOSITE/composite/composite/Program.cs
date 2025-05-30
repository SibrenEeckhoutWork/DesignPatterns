using composite;

IAlbum foto1 = new Foto("Vakantie 2023 - Foto1.jpg");
IAlbum foto2 = new Foto("Vakantie 2023 - Foto2.jpg");
IAlbum foto3 = new Foto("Familie - Foto1.jpg");

// Maak een album
IAlbum vakantieAlbum = new Album("Vakantie 2023");
vakantieAlbum.add(foto1);
vakantieAlbum.add(foto2);

// Maak een ander album
IAlbum familieAlbum = new Album("Familie");
familieAlbum.add(foto3);

// Maak een hoofdalbum dat subalbums bevat
IAlbum hoofdAlbum = new Album("Mijn Foto's");
hoofdAlbum.add(vakantieAlbum);
hoofdAlbum.add(familieAlbum);

IAlbum second = new Album("Second");
second.add(foto1);
second.add(foto2);
familieAlbum.add(second);

// Toon de volledige structuur van het hoofdalbum
hoofdAlbum.Show();