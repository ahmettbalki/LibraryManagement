//(record)Kitap -> title, description, pagesize, publishdate
//(record)author -> name,surname
//(class)category -> name

//Kitaplar listesi oluşturunuz
//Yazarlar listesi oluşturunuz
//Kategoriler listesi oluşturunuz

//Yazarları ekrana yazdıran kodu yaznız
//Kitapları ekrana yazdıran kodu yaznız
//Kategorileri ekrana yazdıran kodu yaznız

//Kitapları Sayfa sayısına göre filtreleyen kodu yazınız
//Kütüphanedeki tüm kitapları sayfa sayısı toplamını hesaplayan kodu yazınız
//Kitap başlığına göre filtreleme işlemleri yapınız
//Kitap ISBN numarasına göre kitapları getiriniz

//Kitaplar listesine yeni bir kitap ekleyip eklendikten sonra listeyi ekran çıktısı olarak veriniz
//*Kitap eklerken Id si veya ISBN numarası daha önceki kitaplarda var ise benzersiz bir kitap girmeniz gereklidir yazısı çıksın

//Kullanıcı bir Id girdiği zaman o idye göre kitabı silen ve yeni listeyi ekrana yazdıran kodu yazınız

//Kullanıcıdan ilk başta Id değeri alıp arama yaptıktan sonra eğer o idye ait bir kitap yok ise "İlgili ıd ye ait bir kitap bulunamadı" desin
//*Güncellenecek olan değerler kullanıcıdan alınacak 

//Kullanıcıdan bir kitap almasını isteyen kodu yazınız
//*Eğer o kitap stokta var ise kitap alındı yazsın, 1 tane varsa o kitap alınsın ve 0 olursa listeden silinsin

//Prime Örnekler
//BookDetail adında bir record oluşturup şu değerler listelenecek
//*Kitap Id, Kitap Başlığı, Kitap Açıklaması, Kitap Sayfa Sayısı, ISBN, Yazar Adı, Kategori Adı

//Kullanıcıdan PageIndex ve PageSize değerlerini alarak sayfalama desteği getiriniz.

using LibraryManagement.ConsoleUI.Models;


//GetAllBooksByPageSizeFilter();
//PageSizeTotalCalculator();
//AddBook();

void PrintAyirac(string metin)
{
    Console.WriteLine(metin);
    Console.WriteLine("-------------------------");
}

bool AddCategoryValidator(Category category)
{
    bool isUnique = true;

    foreach (Category item in categories)
    {
        if (item.Id == category.Id || item.Name == category.Name)
        {
            isUnique = false; 
            break;
        }
    }
    return isUnique;
}

void AddCategory()
{
    Category category = GetCategoryInput();

    bool isUnique = AddCategoryValidator(category);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz id ve isim benzersiz değildir");
        return;
    }
    categories.Add(category);
    GetAllCategories();

}

bool AddAuthorValidator(Author author)
{
    bool isUnique = true;

    foreach (Author item in authors)
    {
        if (item.Id == author.Id || item.Name == author.Name)
        {
            isUnique = false;
            break;
        }
    }
    return isUnique;
}
