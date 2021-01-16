using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Xml.Serialization;

namespace NonVisualComponents.Kokorev
{
    public partial class ComponentBackupXml : Component
    {
        public ComponentBackupXml()
        {
            InitializeComponent();
        }

        public ComponentBackupXml(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// создание xml файла и сохранение его в архив
        /// </summary>
        /// <param name="data">данные для сохранения</param>
        /// <param name="path">путь для создания бекапа</param>
        /// <typeparam name="T">какой то тип</typeparam>
        public void CreateXmlBackup<T>(T data, string path)
        {
            if (File.Exists($"{path}/backup.zip"))
                File.Delete($"{path}/backup.zip");
            var type = data.GetType();
            if (!type.IsSerializable)
                throw new Exception("Класс не сериализуемый");

            try
            {
                var serializer = new XmlSerializer(typeof(T));
                var tempPath = $"{path}/temp";
                var tempDir = Directory.CreateDirectory(tempPath);
                var pathXml = $"{tempPath}/backup.xml";

                using (var output = new FileStream(pathXml, FileMode.OpenOrCreate))
                {
                    serializer.Serialize(output, data);
                }

                var archName = $"{path}/backup.zip";
                ZipFile.CreateFromDirectory(tempPath, archName);
                tempDir.Delete(true);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка сериализации", ex);
            }
        }
    }
}