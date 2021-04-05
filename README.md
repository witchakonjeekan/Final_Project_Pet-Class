# Final_Project_Pet-Class
# Pet_Class

## 1.Program.cs
### 1.1 ขั้นตอนแรกทำการสร้าง Class ที่มีชื่อว่า Pet ขึ้นมา
### 1.2 ทำการสร้างตัวแปรภายใน Class Pet 3ตัวแปร ชื่อว่า name(ชื่อสัตว์) , type(ชนิดของสัตว์) , age(อายุสัตว์เลี้ยง)
#
namespace Pet_Class
{
    class Pet
    {
        private string name;
        private string type;
        private string age;
#
### 1.3 สร้าง public Pet เพื่ออ้างอิงในการใช้งาน name type age ร่วมกันภายใน Class โดยใช้ This
#
        public Pet(string name, string type, string age)
        {
            this.name = name;
            this.type = type;
            this.age = age;
        }
#
### 1.4 สร้างฟังก์ชันในการแสดงผลชื่อ Show()
#    
    public string show()
        {
            return $" {this.name,-30} {this.type,30} {this.age,27}";
        }
    }
#
### 1.5 ในคลาส Program มีการสร้าง static Pet[] เพื่อใช้กำหนดให้ Pet มีความยาวไม่เกิน 10 ตัว ภายใน Array และเริ่มต้นการทำงานที่ count=0
#
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static public Pet[] pets = new Pet[10];
        static public int count = 0;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
#
## 2. Form1.cs
### 2.1 กำหนดพฤติกรรมของ Button1 คือ การสร้าง  Pet โดย textBox1 , omboBox1 , textBox3 และการแสดงผลภายใน Form1 (System.Windows.Forms.Label()) การกำหนดค่าต่างๆไม่ว่าจะเป็น Font , Location , Name เป็นต้น โดยทั้งหมดเป็นการแสดงผลลัพธ์ผ่าน Form1 โดยตรง
#
#	***หาก list_pet ขึ้นสีแดงให้ทำการใส่ 
# private List<System.Windows.Forms.Label> list_pet = new List<System.Windows.Forms.Label>();
# ภายใน Form1.Designer.cs ก่อน
#

private void button1_Click(object sender, EventArgs e)
        {
            Program.pets[Program.count] = new Pet(this.textBox1.Text, this.comboBox1.Text, this.textBox3.Text);
            list_pet.Add(new System.Windows.Forms.Label());
            this.Controls.Add(list_pet[Program.count]);
            list_pet[Program.count].AutoSize = false;
            list_pet[Program.count].Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            list_pet[Program.count].Location = new System.Drawing.Point(36, 50 + (36 * (Program.count + 1)) + 10);
            list_pet[Program.count].Name = "label";
            list_pet[Program.count].Size = new System.Drawing.Size(350, 16);
            list_pet[Program.count].TabIndex = 7;
            list_pet[Program.count].Text = Program.pets[Program.count].show();
            Program.count++;

            this.textBox1.Text = "";
            this.textBox3.Text = "";
        }
#
## 3. Form1.Designer.cs
### 3.1 หน้าแสดงการออกแบบ โดยจะมี 
### -ชื่อ Pet Class 
### -ชื่อ ชนิด อายุ 
### -และช่องในการ input ชื่อ / comboBox เลือกชนิดสัตว์ / input อายุ 
### -Enter คือการเก็บข้อมูล
### -Close การออกจากโปรแกรม
