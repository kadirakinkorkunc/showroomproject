#                                             Galeri Otomasyon Sistemi  


## Nasıl Çalıştırırım: 
Bilgisayarınızda Microsoft Visual Studio 2017’nin kurulu olması ve gerekli olan paketlerin(.NET masaüstü geliştirme,Evrensel Windows Platformu geliştirme, ASP.Net ve web geliştirme,Veri depolama ve işleme) yüklü olması gerekmektedir.Projenin ana dizinindeki .sln dosyasına tıklayarak çalıştırabilirsiniz.  
### Not:
Sql bağlantısı dizin yolu ile belirtildiği için projenin Visual Studio’da açık olduğu   halinde üst sekmelerden View’e tıklayarak Server Explorer içerisinde veritabanı.mdf üzerine sağ tıklayıp properties’e tıklayarak connection stringi kopyalamanız ve “uyeduzenleme.cs” ve “galeriduzenleme.cs” içerisinde satır 22 de tırnak içerisinde kalan yere kendi connection stringinizi yerleştirip derlemeniz gerekmektedir. 
## Amaç:
Proje araç galerisinin takibini ve yönetimini kontrol etmek için  geliştirilmiştir.Kullanıcılar sisteme üye olabilir, galerideki araçlar hakkında gerekli bilgileri görüntüleyebilir, yöneticiler ise üyeler ve araçlar üzerinde görüntüleme, güncelleme ve silme işlemlerini gerçekleştirebilir.  

## Nesneler ve İlişkiler:  
###   •	Yönetici Nesnesi:
        Galerideki araçlar ve üyeler üzerinde ekleme,silme,güncelleme ve görüntüleme işlemlerini yapabilir.  
###   •	Müşteri Nesnesi:
        Sisteme üye olabilir, giriş yapabilir ve galerideki araçları görüntüleyebilir.  

## Ekranlar ve Bileşenler:  
### •	Ana Giriş:
        Yapılmak istenen işleme göre yönlendirme yapan ekrandır(Görsel 1)  
![alt text](https://github.com/kadirakinkorkunc/showroomproject/blob/master/img/gorsel1.png)--Görsel 1
--
### •	Yönetici Girişi:
        İki adet girdi alarak bunları kontrol ederek yöneticiyi seçim ekranına yönlendirir.(Görsel 2.1) 
![alt text](https://github.com/kadirakinkorkunc/showroomproject/blob/master/img/gorsel2_1.png)--Görsel 2.1
--
### •	Galeri Düzenleme:
        Yönetici bu ekranda araçları görüntüleyebilir,silebilir,güncelleyebilir ve yeni araç ekleyebilir.(Görsel 2.2)  
![alt text](https://github.com/kadirakinkorkunc/showroomproject/blob/master/img/gorsel2_2.png)--Görsel 2.2
--
### •	Üye Düzenleme:
        Yönetici bu ekranda üyeleri görüntüleyebilir,silebilir,güncelleyebilir ve yeni üye ekleyebilir.(Görsel 2.3)  
![alt text](https://github.com/kadirakinkorkunc/showroomproject/blob/master/img/gorsel2_3.png)--Görsel 2.3
 --
### •	Kayıt Ol:
        Müşteri 4 adet girdi vererek sisteme kayıt olabilir.(Görsel 3)  
 ![alt text](https://github.com/kadirakinkorkunc/showroomproject/blob/master/img/gorsel3.png)--Görsel 3
 --    
### •	Müşteri Girişi:
        Müşteri kayıt olduğu bilgiler ile 2 girdi vererek giriş yapabilir.(Görsel 4)  
![alt text](https://github.com/kadirakinkorkunc/showroomproject/blob/master/img/gorsel4.png)--Görsel 4
--
## •	GALERİ AYDIN: 
        Müşteriye sistemde kayıtlı olan arabalar ve bilgilerini gösterir.(Görsel 4.1)  
![alt text](https://github.com/kadirakinkorkunc/showroomproject/blob/master/img/gorsel4_1.png)-Görsel 4.1
--
