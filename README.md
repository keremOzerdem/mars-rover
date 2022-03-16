# MARS ROVER
Mars’a bir keşif görevi için roverlar gönderilmek isteniyor. Roverların Mars üzerine konuşlandırılması ve hareket etmesi bir C# uygulaması üzerinden kontrol edilecektir. Bu iş için:
- C# kullanarak bir uygulama yazılmalıdır.
- Uygulama bir ana menü arayüzüne sahip olmalıdır, bunun için console arayüzü kullanılacaktır. (Form değil)
- Program ayağa kalktığında kullanıcıdan roverların konuşlandırılacağı platonun boyutlarını istemelidir.
	- Örn girdi: “5 5”
	- Girdi sonucunda boyutları 5x5 olan sol alt sınırı (0,0) sağ üst sınırı (5,5) olan bir plato oluşmalıdır.
- Boyut girildikten sonra kullanıcıyı program arayüzü karşılamalıdır ve kullanıcıya 3 seçenek sunmalıdır.
	1. Rover konuşlandır (Deploy)
	2. Konuşlandırılmış roverlardan birisini yönlendir. (Move)
	3. Programdan çık (Exit)
- Rover konuşlandır seçeneği seçilirse plato üzerinde kullanıcı tarafından alınan nokta ve yönde bir rover yerleştirilmelidir. Yeni rover var olan bir rover ile aynı lokasyona yerleştirilemez.
	- Örn girdi: “3 2 N”
	- Girdideki ilk parametre X eksenini ikinci parametre Y eksenini üçüncü parametre ise yönü belirmektedir. (N=North, S=South, E=East, Q=West)
- Konuşlandırılmış roverlardan birisini yönlendir seçeneği seçilirse program konuşlandırılmış roverların hepsini listeleyip kullanıcı tarafından yapılan seçim ve verilen hareket komutu sonucu o roverı plato üzerinde hareket ettirmelidir. Seçilen rover hareket ederken diğer konuşlandırılmış roverlar üzerinden geçemez ve verilen komut sonucu plato dışarısına çıkamaz.
	- Örn girdi: “MMRMLMR”
	- Girdideki harfler M=Move, R=Turn right, L=Turn Left
	- Hareket sonucunda roverın son konumu ve yönü çıktı olarak verilmelidir.
- Programdan çık seçeceği seçildiğinde kullanıcıdan bu aksiyonu doğrulaması için herhangi bir girdi girmesi (örn. Exit) istenebilir bu tercihe bağlıdır. İşlemler tamamlandığında programına kapanması beklenir. Bu seçenek seçilmediği sürece program sürekli ana menüye dönmelidir.