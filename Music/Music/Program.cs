﻿using System.Diagnostics;

HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("https://rur.hitmotop.com/get/music/20220726/SHAMAN_-_YA_RUSSKIJJ_74622610.mp3");
byte[] data = response.Content.ReadAsByteArrayAsync().Result;
File.WriteAllBytes("C:\\Users\\ilruz\\OneDrive\\Рабочий стол\\Дора-дура.mp3", data);

Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\ilruz\\OneDrive\\Рабочий стол\\Дора-дура.mp3", UseShellExecute = true });