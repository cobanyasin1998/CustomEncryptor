
using CustomEncryptor;

PassEncryptor passEncryptor = new PassEncryptor();
string value = "Yasin Çoban 445343";
string encryptedPassword = passEncryptor.NextLevelEnc(value, 3);
string decryptedPassword = passEncryptor.NextLevelDec(encryptedPassword);
Console.WriteLine(encryptedPassword);
Console.WriteLine(decryptedPassword);

encryptedPassword = passEncryptor.ByteBaseEnc(value);
decryptedPassword = passEncryptor.ByteBaseDec(encryptedPassword);
Console.WriteLine(encryptedPassword);
Console.WriteLine(decryptedPassword);

//for (int i = 0; i < 5; i++)
//{
//    var e2 = passEncryptor.ByteBaseEnc(value);
//    var d2 = passEncryptor.ByteBaseDec(e2);

//    Console.WriteLine($"E2: {e2}");
//    Console.WriteLine($"D2: {d2}");
//}

//for (int i = 0; i < 5; i++)
//{
//    var e3 = passEncryptor.RandomByteBaseEnc(value, "this is my key");
//    Console.WriteLine($"E3: {e3}");
//}

//for (int i = 0; i < 5; i++)
//{
//    var e4 = passEncryptor.MD5_Enc(value + (i + 1));
//    Console.WriteLine($"E4: {e4}");
//}

for (int i = 0; i < 5; i++)
{
    var e5 = passEncryptor.SHA256_Encr(value);
    Console.WriteLine($"E5: {e5}");
}



Console.ReadLine();