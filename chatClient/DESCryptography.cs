﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace chatClient
{
    static class DESCryptography // класс для шифрования и расшифровки сообщений с помощью алгоритма шифрования Triple DES
    {

        public static byte[] Key { get; set; } // свойство для хранения секретного ключа
        public static byte[] Iv { get; set; } // свойство для хранения вектора инициализации


        /*Triple DES — симметричный блочный шифр, созданный Уитфилдом Диффи, Мартином Хеллманом и Уолтом Тачманном в 1978
         * году на основе алгоритма DES с целью устранения главного недостатка последнего — малой длины ключа, который может
         * быть взломан методом полного перебора ключа.
         */

        // метод шифрует данные
        static public byte[] Encrypt(string text, byte[] key, byte[] iv)
        {
            byte[] result; // создаем массив байтов, куда будут записанны зашифрованные данные

            // using определяет область, по завершении которой объект удаляется
            using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider()) // создаем экземпляр класса TripleDESCryptoServiceProvider для доступа к версии служб шифрования (CSP англ. cryptography service provider) Triple DES алгоритма.
            {

                des.IV = iv; // присваиваем вектор инициализации
                des.Key = key; // присваиваем секретный ключ

                ICryptoTransform encryptor = des.CreateEncryptor(des.Key, des.IV); // создаем симметричный TripleDES объект-шифратор с заданным ключем и вектором инициализации

                using (MemoryStream stream = new MemoryStream()) // создаем экземпляр класса MemoryStream (поток , резервным хранилищем которого является память) с расширяемой емкостью, инициализированной нулевым значением.
                {
                    using (CryptoStream cstream = new CryptoStream(stream, encryptor, CryptoStreamMode.Write)) // определяем поток, который связывает потоки данных с криптографическими преобразованиями.
                    {
                        using (StreamWriter sw = new StreamWriter(cstream)) // создаем экземпляр класса StreamWriter (реализует TextWriter для записи символов в поток) для указанного потока, использует кодировку UTF-8 и размер буфера по умолчанию 
                        {
                            sw.Write(text); // зписываем в поток строку
                        }
                        result = stream.ToArray(); // записываем содержимое потока в массив байтов result
                    }
                }
            }
            return result; // возвращаем зашифрованные данные
        }

        // метод расшифровывает данные
        static public byte[] Decrypt(byte[] chiper, byte[] key, byte[] iv)
        {
            string text; // создаем переменную для расшифрованных данных
            using (TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider())
            {
                des.IV = iv; // присваиваем вектор инициализации
                des.Key = key; // присваиваем секретный ключ

                ICryptoTransform decryptor = des.CreateDecryptor(des.Key, des.IV); // создаем симметричный TripleDES объект-дешифратор с указанным ключем и вектором инициализации

                using (MemoryStream stream = new MemoryStream(chiper)) // создаем экземпляр класса MemoryStream (поток , резервным хранилищем которого является память) с расширяемой емкостью, инициализированной нулевым значением.
                {
                    using (CryptoStream cstream = new CryptoStream(stream, decryptor, CryptoStreamMode.Read)) // определяем поток, который связывает потоки данных с криптографическими преобразованиями.
                    {
                        using (StreamReader sr = new StreamReader(cstream)) // реализуем объект TextReader, который считывает символы из потока байтов в кодировке UTF-8
                        {
                            text = sr.ReadToEnd(); // считываем все символы, начиная с текущей позиции до конца потока
                        }
                    }
                }
            }
            return Encoding.UTF8.GetBytes(text); // возвращаем расшифрованные данные
        }
    }
}

