
Merhabalar

Bu Örnekde Kullanı Prensibler

1. Single Responsibility Prensibi => Her bir Mesaj servisi kendi özelliklerini barındıracak şekilde kapsüllemesini gerçekleştirdik ve her bir nesneye sadece bir görev atamış olduk
2. Open Closed => Değişime Kapalı Gelişime Açık Bir Şekilde Örnekledik
3. Dependency Inversion =>Dependency Injection desing pattern kullanarak Her Mesaj Service Nesnesini Message Abstract Classı ile soyutlamış olduk bu durum bizi bağımlılıktan kurtarmış oldu ilerleyen dönemlerde daha farklı mesaj gönderme servisleri ekleyebiliriz 

Tanımlar


Single Responsibility Principle
“Tek Sorumluluk” anlamına gelen bu prensipte amaç; geliştirilen projede bir güncelleme veya değişiklik yapılması istendiğinde kodların içinde kaybolmadan, yalnızca ilgili metoda giderek istenilen değişikliğin yapılmasının sağlanmasıdır.Yani; bir fonksiyona birden fazla iş verip onu birçok işten sorumlu tutmak yerine, her bir iş için ayrı bir metot oluşturmalı ve ilerleyen zamanlarda bir değişiklik yapılacağında da kolaylıkla ilgili metoda giderek gerekli değişiklikleri yapabilmemiz gerekmektedir.

Open Closed Prenciple
Bu prensibe göre uygulamada bulunan yazılım varlıkları geliştirilmeye açık ancak kod değişimine kapalıdır.Yani bir nesne davranışını değiştirmeden yeni özellikler kazabiliyor olmalıdır. Bu prensip, sürdürülebilir ve tekrar kullanılabilir yapıda kod yazmanın temelini oluşturur.

Dependency Inversion Principle
Bu prensip, bileşenler arasındaki bağımlılıklarla ilgilidir ve bu prensibe göre;

Yüksek seviyeli modüller, düşük seviyeli modüllere bağlı olmamalıdır. Her ikisi de soyutlamalara dayanmalıdır.

Soyutlamalar ayrıntılara bağlı olmamalıdır. Detaylar soyutlamalara bağlı olmalıdır.

Basit bir deyişle, yazılımın bileşenleri arasında sıkı bir bağlantı olmaması gerektiğini ve bundan kaçınmak için bileşenlerin soyutlamaya bağlı olması gerektiğini söylemektedir.
