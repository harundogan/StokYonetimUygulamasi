# StokYonetimUygulamasi
Bu proje C# ve MSSQL kullanılarak oluşturulmuştur.
Projede Ado.Net kullanılarak veritabanı bağlantısı kurulmuş ve veri ekleme,güncelleme ve silme işlemleri yapılmıştır.
Yeni ürünler eklenebilmekte,mevcut ürünler güncellenmekte ve silinebilmektedir.
Verileri şifrelemeyi merak ettiğim için projede güvenli olduğuna kanaat getirdiğim TripleDES yöntemini kullandım.
Mevcut kullanıcı şifresini sıfırlarken şifreleme yöntemi sayesinde bir key oluşuyor ve bu key veritabanına şifre olarak kaydediliyor.
Veritabanına erişen herhangi biri gerçek şifreyi değil bu key anahtarını görüyor.
Ekstra olarak projede şifre değiştirirken StreamWriter metodu ile bir dosya oluşturuyor ve key anahtarı ile şifreyi buraya atıyoruz.
Ve bu key ile şifrenin oluşturulan dosyada görülememesi için karakter karakter okuyarak char tipine dönüştürerek verilerin okunamayacak bir şekle dönüşmesini sağlıyoruz.
Ve ek olarak projede şifre değiştirirken şifrenin güvenli olup olmadığı konusunda kullanıcıya girdiği şifrenin zayıf mı güçlü mü olduğu konusunda yardımcı oluyoruz.
* Uygulamayı kullanmak isterseniz ilk önce şifremi unuttum linkine tıklayarak açılan panelden yeni şifre oluşturmalısınız.
