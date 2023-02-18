using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video();
        video1.SetAuthor("Warner Bros.Pictures");
        video1.SetLength(176);
        video1.SetTitle("The Flash – Official Trailer");

        Comment comment1Video1 = new Comment();
        comment1Video1.SetComment("Nearly 35 years later, and Michael Keaton still got it.");
        comment1Video1.SetCommenter("Joseph Ocasio");
        video1.SetComment(comment1Video1);

        Comment comment2Video1 = new Comment();
        comment2Video1.SetComment("Gosh. Hearing Batman say Im Batman then Batmanning all over the place was truly one of the moments of all time");
        comment2Video1.SetCommenter("Damian Santana");
        video1.SetComment(comment2Video1);

        Comment comment3Video1 = new Comment();
        comment3Video1.SetComment("Ezra Miller, the only person to be the flash and reverse flash in real life");
        comment3Video1.SetCommenter("Cam the spaceman");
        video1.SetComment(comment3Video1);

        Comment comment4Video1 = new Comment();
        comment4Video1.SetComment("Words cannot describe how amazing it feels to see Michael Keaton back as Batman");
        comment4Video1.SetCommenter("Mo HaHa");
        video1.SetComment(comment4Video1);

        Video video2 = new Video();
        video2.SetAuthor("Calvin Harris");
        video2.SetTitle("Calvin Harris - Slide (Official Audio) ft. Frank Ocean, Migos");
        video2.SetLength(231);

        Comment comment1Video2 = new Comment();
        comment1Video2.SetComment("One of the best summer songs of the last decade.");
        comment1Video2.SetCommenter("Lowry Tv");
        video2.SetComment(comment1Video2);

        Comment comment2Video2 = new Comment();
        comment2Video2.SetComment("This song makes me want to take a long drive in the summer and enjoy fresh fruit and beaches");
        comment2Video2.SetCommenter("Morgan Cobb");
        video2.SetComment(comment2Video2);

        Comment comment3Video2 = new Comment();
        comment3Video2.SetComment("5 years already this song is too good, it always makes my day brighter.");
        comment3Video2.SetCommenter("Mr. M00n");
        video2.SetComment(comment3Video2);

        Video video3 = new Video();
        video3.SetAuthor("Mr. Beast");
        video3.SetLength(480);
        video3.SetTitle("1000 Blind People See For The First Time");

        Comment comment1Video3 = new Comment();
        comment1Video3.SetComment("For them, it is the happiest thing! MrBeast is awesome!");
        comment1Video3.SetCommenter("FatSongsong and ThinErmao");
        video3.SetComment(comment1Video3);

        Comment comment2Video3 = new Comment();
        comment2Video3.SetComment("Mrbeast is really changing the world and helping people in need. You're so generous to spend millions and millions of dollars to help people. Thank you Mrbeast.");
        comment2Video3.SetCommenter("Tara th");
        video3.SetComment(comment2Video3);

        Comment comment3Video3 = new Comment();
        comment3Video3.SetComment("Solo puedo aplaudir a un ser tan humilde");
        comment3Video3.SetCommenter("Sebastián Inostroza");
        video3.SetComment(comment3Video3);

        Comment comment4Video3 = new Comment();
        comment4Video3.SetComment("This gave me tears of how wholesome this was.");
        comment4Video3.SetCommenter("Unknow");
        video3.SetComment(comment4Video3);

        Video video4 = new Video();
        video4.SetAuthor("Vicesat");
        video4.SetTitle("TRUCOS | Comprar un Coche Roto y Arreglarlo con Poco Dinero | BRZ");
        video4.SetLength(725);

        Comment comment1Video4 = new Comment();
        comment1Video4.SetComment("Siempre Vicesat alregrando los dias con unos videos que no se pueden dejar pasar.");
        comment1Video4.SetCommenter("Franchu");
        video4.SetComment(comment1Video4);

        Comment comment2Video4 = new Comment();
        comment2Video4.SetComment("Soy el único al que siempre le saben a poco los vídeos de este crack. Más contenido que nos dejas queriendo más!!!!");
        comment2Video4.SetCommenter("Karleon Ruiz");
        video4.SetComment(comment2Video4);

        Comment comment3Video4 = new Comment();
        comment3Video4.SetComment("Uno se levanta aburrido, hasta que vez que vicesat acaba de subir un vídeo y te cambia el ánimo por completo");
        comment3Video4.SetCommenter("Alejo Taborda");
        video4.SetComment(comment3Video4);

        Comment comment4Video4 = new Comment();
        comment4Video4.SetComment("Como es el consumo en relación a el GT86? Cuánto te consume?");
        comment4Video4.SetCommenter("Iván Miranda");
        video4.SetComment(comment4Video4);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach(Video videito in videos)
        {
            videito.Display();
            Console.WriteLine("");
        }

    }
}