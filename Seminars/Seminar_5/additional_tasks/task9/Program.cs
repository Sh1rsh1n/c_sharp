/*
Заданы массивы названий и обозначений транспортных средств, а также
их скоростей, например: a – автомобиль, 70 км/ч; v – велосипед, 12 км/ч;
m - мотоцикл, 60 км/ч; p – поезд, 90 км/ч; s – самолет, 800 км/ч)
По введенному обозначению транспортного средства
выводится его название и скорость.
*/


char[] transportSymbol = { 'c', 'b', 'm', 't', 'p' };

string[] transportTitle = { "car", "bicycle", "motocycle", "train", "plane" };

int[] transportSpeed = { 70, 12, 60, 90, 800 };



Console.WriteLine(transportCreator('c', transportSymbol, transportTitle, transportSpeed));