using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace AManager
{
    public partial class Main : Sunny.UI.UIForm
    {
        string Jsonword;
        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private TabPage tabPage1;
        private Button button1;
        private Achievements AC = new();
        private PictureBox border;
        private PictureBox images;
        private Label label1;
        private ListView ucListView1;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx1;
        private HZH_Controls.Controls.ShadowComponent shadowComponent1;
        private System.ComponentModel.IContainer components;
        DataContractJsonSerializer b = new DataContractJsonSerializer(typeof(Achievements));

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucTextBoxEx1 = new HZH_Controls.Controls.UCTextBoxEx();
            this.ucListView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.images = new System.Windows.Forms.PictureBox();
            this.border = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.shadowComponent1 = new HZH_Controls.Controls.ShadowComponent(this.components);
            this.uiTabControlMenu1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabPage1);
            this.uiTabControlMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(40, 200);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(0, 35);
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.shadowComponent1.SetShowShadow(this.uiTabControlMenu1, false);
            this.uiTabControlMenu1.Size = new System.Drawing.Size(799, 445);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.Style = Sunny.UI.UIStyle.Orange;
            this.uiTabControlMenu1.TabIndex = 0;
            this.uiTabControlMenu1.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiTabControlMenu1.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(249)))), ((int)(((byte)(241)))));
            this.tabPage1.Controls.Add(this.ucTextBoxEx1);
            this.tabPage1.Controls.Add(this.ucListView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.images);
            this.tabPage1.Controls.Add(this.border);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(201, 0);
            this.tabPage1.Name = "tabPage1";
            this.shadowComponent1.SetShowShadow(this.tabPage1, false);
            this.tabPage1.Size = new System.Drawing.Size(598, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "所有成就";
            // 
            // ucTextBoxEx1
            // 
            this.ucTextBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx1.ConerRadius = 10;
            this.ucTextBoxEx1.DecLength = 2;
            this.ucTextBoxEx1.FillColor = System.Drawing.Color.Empty;
            this.ucTextBoxEx1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx1.InputText = "稀有度:";
            this.ucTextBoxEx1.InputType = HZH_Controls.TextInputType.NotControl;
            this.ucTextBoxEx1.IsFocusColor = true;
            this.ucTextBoxEx1.IsRadius = true;
            this.ucTextBoxEx1.IsShowClearBtn = false;
            this.ucTextBoxEx1.IsShowKeyboard = false;
            this.ucTextBoxEx1.IsShowRect = true;
            this.ucTextBoxEx1.IsShowSearchBtn = false;
            this.ucTextBoxEx1.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx1.Location = new System.Drawing.Point(385, 208);
            this.ucTextBoxEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx1.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucTextBoxEx1.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ucTextBoxEx1.Name = "ucTextBoxEx1";
            this.ucTextBoxEx1.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx1.PasswordChar = '\0';
            this.ucTextBoxEx1.PromptColor = System.Drawing.Color.Gray;
            this.ucTextBoxEx1.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx1.PromptText = "";
            this.ucTextBoxEx1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx1.RectWidth = 1;
            this.ucTextBoxEx1.RegexPattern = "";
            this.shadowComponent1.SetShowShadow(this.ucTextBoxEx1, false);
            this.ucTextBoxEx1.Size = new System.Drawing.Size(209, 36);
            this.ucTextBoxEx1.TabIndex = 6;
            // 
            // ucListView1
            // 
            this.ucListView1.Location = new System.Drawing.Point(61, 72);
            this.ucListView1.Name = "ucListView1";
            this.shadowComponent1.SetShowShadow(this.ucListView1, false);
            this.ucListView1.Size = new System.Drawing.Size(298, 323);
            this.ucListView1.TabIndex = 5;
            this.ucListView1.UseCompatibleStateImageBehavior = false;
            this.ucListView1.View = System.Windows.Forms.View.Tile;
            this.ucListView1.SelectedIndexChanged += new System.EventHandler(this.ucListView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(404, 249);
            this.label1.Name = "label1";
            this.shadowComponent1.SetShowShadow(this.label1, false);
            this.label1.Size = new System.Drawing.Size(168, 101);
            this.label1.TabIndex = 4;
            this.label1.Text = "点击其中一项来查看介绍";
            // 
            // images
            // 
            this.images.BackgroundImage = global::AManager.Properties.Resources.FRLGGlitchMenu000;
            this.images.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.images.Location = new System.Drawing.Point(437, 109);
            this.images.Name = "images";
            this.shadowComponent1.SetShowShadow(this.images, false);
            this.images.Size = new System.Drawing.Size(95, 85);
            this.images.TabIndex = 3;
            this.images.TabStop = false;
            // 
            // border
            // 
            this.border.BackgroundImage = global::AManager.Properties.Resources.normal;
            this.border.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.border.Location = new System.Drawing.Point(430, 103);
            this.border.Name = "border";
            this.shadowComponent1.SetShowShadow(this.border, false);
            this.border.Size = new System.Drawing.Size(107, 97);
            this.border.TabIndex = 2;
            this.border.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 353);
            this.button1.Name = "button1";
            this.shadowComponent1.SetShowShadow(this.button1, false);
            this.button1.Size = new System.Drawing.Size(121, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shadowComponent1
            // 
            this.shadowComponent1.ShadowHeight = 0.3F;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.CloseAskString = "确认退出吗?";
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.Controls.Add(this.uiTabControlMenu1);
            this.IsForbidAltF4 = true;
            this.Name = "Main";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.ShowRadius = false;
            this.ShowShadow = true;
            this.Style = Sunny.UI.UIStyle.Orange;
            this.Text = "成就查看器";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.Load += new System.EventHandler(this.Main_Load);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            this.ResumeLayout(false);

        }

        public Main()
        {
            InitializeComponent();

            StreamReader sw = new("AC.json");
            Jsonword = sw.ReadToEnd();
            AC = JsonConvert.DeserializeObject<Achievements>(Jsonword);
            //byte[] json = System.Text.Encoding.UTF8.GetBytes(Jsonword);
            //MemoryStream ms = new MemoryStream(json);
            //AC = (Achievements)b.ReadObject(ms);
            for (int i = 0; i < AC.AchievementCollections.Length; i++)
            {
                ucListView1.Items.Add(AC.AchievementCollections[i].Name);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //b.WriteObject(ms, AI);
            //json = ms.ToArray();
            //ms.Close();
            //string jsonstring = System.Text.Encoding.UTF8.GetString(json);
            //listView1.Items.Add(jsonstring);

        }

        private void ucListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection selectedIndexCollection = ucListView1.SelectedIndices;
            foreach (int index in selectedIndexCollection)
            {
                label1.Text = AC.AchievementCollections[index].Statements;
                DecideBorder(AC, index);
                DecideImage(AC, index);
            }
        }
        void DecideBorder(Achievements a, int index)
        {
            if (a.AchievementCollections[index].IsAchieved == true)
            {
                switch (a.AchievementCollections[index].Difficulty)
                {
                    case 0:
                        border.BackgroundImage = Properties.Resources.green;
                        ucTextBoxEx1.InputText = "稀有度：普通";
                        ucTextBoxEx1.ForeColor = Color.Green;
                        break;
                    case 1:
                        border.BackgroundImage = Properties.Resources.red;
                        ucTextBoxEx1.InputText = "稀有度：不常见";
                        ucTextBoxEx1.ForeColor = Color.Red;
                        break;
                    case 2:
                        border.BackgroundImage = Properties.Resources.orange;
                        ucTextBoxEx1.InputText = "稀有度：稀有";
                        ucTextBoxEx1.ForeColor = Color.Orange;
                        break;
                    case 3:
                        border.BackgroundImage = Properties.Resources.purple;
                        ucTextBoxEx1.InputText = "稀有度：史诗";
                        ucTextBoxEx1.ForeColor = Color.Purple;
                        break;
                    default:
                        border.BackgroundImage = Properties.Resources.green;
                        ucTextBoxEx1.InputText = "稀有度：普通";
                        ucTextBoxEx1.ForeColor = Color.Green;
                        break;
                }
            }
            else
            {
                border.BackgroundImage = Properties.Resources.normal;
                ucTextBoxEx1.InputText = "稀有度：";
                ucTextBoxEx1.ForeColor = Color.Green;

            }
        }

        void DecideImage(Achievements a, int index)
        {
            //决定具体图像
            if (a.AchievementCollections[index].IsAchieved == true)
            {
                switch (index)
                {
                    case 0:
                        images.BackgroundImage = Properties.Resources.Bag_超级球_Sprite;
                        break;
                    case 1:
                        images.BackgroundImage = Properties.Resources.Bag_高级球_Sprite;
                        break;
                    case 2:
                        images.BackgroundImage = Properties.Resources.Bag_陨石4_Sprite;
                        break;
                    case 3:
                        images.BackgroundImage = Properties.Resources.Bag_奈克洛索尔合体器_Sprite;
                        break;
                    case 4:
                        images.BackgroundImage = Properties.Resources.Bag_奇异卡片_Sprite;
                        break;
                    case 5:
                        images.BackgroundImage = Properties.Resources.Bag_气势披带_Sprite;
                        break;
                    case 6:
                        images.BackgroundImage = Properties.Resources.Bag_遗失物_IV_Sprite;
                        break;
                    case 7:
                        images.BackgroundImage = Properties.Resources.Bag_王者之证_Sprite;
                        break;
                    case 8:
                        images.BackgroundImage = Properties.Resources.Bag_白金宝珠_Sprite;
                        break;
                    case 9:
                        images.BackgroundImage = Properties.Resources.Bag_节拍器_Sprite;
                        break;
                    case 10:
                        images.BackgroundImage = Properties.Resources.神奥强壮究极奖章;
                        break;
                    case 11:
                        images.BackgroundImage = Properties.Resources.世界才能奖章;
                        break;
                    case 12:
                        images.BackgroundImage = Properties.Resources.冠军奖章;
                        break;
                    case 13:
                        images.BackgroundImage = Properties.Resources.豪华高贵奖章;
                        break;
                    default:
                        images.BackgroundImage = Properties.Resources.FRLGGlitchMenu000;
                        break;

                }
            }
            else
            {
                images.BackgroundImage = Properties.Resources.FRLGGlitchMenu000;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
