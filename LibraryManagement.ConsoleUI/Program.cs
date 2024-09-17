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

using LibraryManagement.ConsoleUI;

List<Book> books = new List<Book>()
{
    new Book(1,"Germinal","Kömür Madeni",351,"2012 Mayıs","9781234567897"),
    new Book(2,"Suç ve Ceza","Raskolnikov'un Hayatı",600,"1978 Şubat","5461234567897"),
    new Book(3,"Kumarbaz","Bir Öğretmenin Hayatı",220,"2009 Ocak","5461234567856"),
    new Book(4,"Araba Sevdası","Arbayla alakası olmayan kitap",180,"1999 Ocak","5461234567878"),
    new Book(5,"Ateşten Gömlek","Kurtuluş savaşını anlatan kitap",1100,"2001 Eylül","5461234567885"),
    new Book(6,"Kaşağı","Saçma bir kitap",94,"1985 Haziran","5461234567811"),
    new Book(7,"28 Şampiyonluk","Şerefli şampiyonlukları anlatır",1907,"2017 Mayıs","5461234561907"),
    new Book(8,"Şampiyonluk","Muhteşem Şampiyonluklar",230,"850 Ağustos","5461234562003"),
    new Book(9,"Ali Arı","Ceo Hikayesi",630,"2020 Aralık","54612345678855"),
};
List<Author> authors = new List<Author>()
{
    new Author(1,"Emile","Zola"),
    new Author(2,"Fyodor","Dostoyevksi"),
    new Author(3,"Recaizade Mahmut","Ekrem"),
    new Author(4,"Halide Edip","Adıvar"),
    new Author(5,"Ömer","Seyfettin"),
    new Author(6,"Ali","Koç"),
};
List<Category> categories = new List<Category>()
{
    new Category(1,"Dünya Klasikleri"),
    new Category(2,"Türk Klasikleri"),
    new Category(3,"Bilim Kurgu"),
};

//GetAllBooksByPageSizeFilter();
//PageSizeTotalCalculator();
//AddBook();

void PrintAyirac(string metin)
{
    Console.WriteLine(metin);
    Console.WriteLine("-------------------------");
}
void GetAllBooks()
{
    PrintAyirac("Kitaplar");
    foreach (Book book in books)
    {
        Console.WriteLine(book);
    }
}
void GetAllAuthors()
{
    PrintAyirac("Yazarlar");

    foreach (Category category in categories)
    {
        Console.WriteLine(category);
    }
}
void GetAllCategories()
{
    PrintAyirac("Kategoriler");

    foreach (Author author in authors)
    {
        Console.WriteLine(author);
    }
}

void GetAllBooksByPageSizeFilter()
{
    PrintAyirac("Sayfa sayısına göre filtreleme");

    Console.WriteLine("Lütfen minimum değeri giriniz.");
    int min = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen maximum değeri giriniz.");
    int max = Convert.ToInt32(Console.ReadLine());

    foreach (Book book in books)
    {
        if (book.PageSize<=max && book.PageSize>min)
        {
            Console.WriteLine(book);
        }
    }
}

void PageSizeTotalCalculator()
{
    int total = 0;
    foreach (Book book in books)
    {
        total += book.PageSize;
    }
    Console.WriteLine(total);
}

void GetAllBooksByTitleContains()
{
    Console.WriteLine("Lütfen kitap başlığını giriniz.");
    string text = Console.ReadLine();

    foreach (Book book in books)
    {
        if (book.Title.Contains(text, StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine(book);
        }
    }
}

void GetByISBN()
{
    foreach (Book book in books)
    {
        Console.WriteLine("Lütfen ISBN numarasını giriniz.");
        string isbn = Console.ReadLine();
        if (book.ISBN == isbn)
        {
            Console.WriteLine(book);
        }
    }
}

void GetBookInputs(out int id, out string title, out string description, out int pageSize, out string publishDate, out string isbn)
{
    Console.WriteLine("Lütfen kitap id sini giriniz.");
    id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap başlığını giriniz.");
    title = Console.ReadLine();

    Console.WriteLine("Lütfen kitap açıklamasını giriniz.");
    description = Console.ReadLine();

    Console.WriteLine("Lütfen kitap sayfasını giriniz.");
    pageSize = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap çıkış tarihini giriniz.");
    publishDate = Console.ReadLine();

    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz.");
    isbn = Console.ReadLine();
}

bool AddBookValidator(Book book)
{
    bool isUnique = true;

    foreach (Book item in books)
    {
        if (item.Id == book.Id || item.ISBN == book.ISBN)
        {
            isUnique = false;
            break;
        }
    }
    
    return isUnique;
}

Book GetBookInputs2()
{
    Console.WriteLine("Lütfen kitap id sini giriniz.");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap başlığını giriniz.");
    string title = Console.ReadLine();

    Console.WriteLine("Lütfen kitap açıklamasını giriniz.");
    string description = Console.ReadLine();

    Console.WriteLine("Lütfen kitap sayfasını giriniz.");
    int pageSize = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kitap çıkış tarihini giriniz.");
    string publishDate = Console.ReadLine();

    Console.WriteLine("Lütfen kitap ISBN numarasını giriniz.");
    string isbn = Console.ReadLine();

    Book book = new Book(id, title, description, pageSize, publishDate, isbn);
    return book;
}
void AddBook()
{
    Book book = GetBookInputs2();

    bool isUnique = AddBookValidator(book);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz kitap benzersiz değildir.");
        return;
    }

    books.Add(book);

    GetAllBooks();
}

Category GetCategoryInput()
{
    Console.WriteLine("Lütfen kategori id si giriniz.");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen kategori adı giriniz");
    string name = Console.ReadLine();

    Category category = new Category(id, name);
    return category;
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

Author GetAuthorInput()
{
    Console.WriteLine("Lütfen yazar id si giriniz.");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Lütfen yazar adı giriniz");
    string name = Console.ReadLine();

    Console.WriteLine("Lütfen yazar soyadı giriniz");
    string surname = Console.ReadLine();

    Author author = new Author(id, name, surname);

    return author;
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

void AddAuthor()
{
    Author author = GetAuthorInput();

    bool isUnique = AddAuthorValidator(author);

    if (!isUnique)
    {
        Console.WriteLine("Girmiş olduğunuz id ve isim benzersiz değildir");
        return;
    }
    authors.Add(author);
    GetAllAuthors();

}