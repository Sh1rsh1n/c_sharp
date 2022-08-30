String s = "C:/Users/Sh1rer/Desktop/c_sharp/Seminars/Seminar_6_HomeWork";
DirectoryInfo di = new DirectoryInfo(s);
Console.WriteLine(di.CreationTime);

FileInfo[] fi = di.GetFiles();

