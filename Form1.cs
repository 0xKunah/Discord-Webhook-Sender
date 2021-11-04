using DiscordWebhook;
using System;
using System.Windows.Forms;

namespace DiscordRPC
{
    public partial class Form1 : Form
    {

        string[] default_values = {
            "Webhook URL",
            "Message Author",
            "Author profile Pic URL",
            "Message Text here...",
            "Attachment URL",
            "Title",
            "Description",
            "Color",
            "Author",
            "Footer",
            "Thumbnail",
            "URL"
        };
        public Form1()
        {
            InitializeComponent();
            reset_func();
            isText.Checked = true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset_func();
        }

        public void reset_func()
        {
            webhook_id.Text = default_values[0];
            author.Text = default_values[1];
            profilepic.Text = default_values[2];
            message.Text = default_values[3];
            atch.Text = default_values[4];
            title.Text = default_values[5];
            desc.Text = default_values[6];
            color.Text = default_values[7];
            e_author.Text = default_values[8];
            footer.Text = default_values[9];
            thumb.Text = default_values[10];
            url.Text = default_values[11];
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (!isText.Checked && !isEmbed.Checked)
            {
                MessageBox.Show("Select a Webhook type (text or embed)");
            }
            else
            {
                if ((webhook_id.Text != null || webhook_id.Text != default_values[0])
                    && (author.Text != null || author.Text != default_values[1])
                    && (profilepic.Text != null || profilepic.Text != default_values[2])
                    && (message.Text != null || message.Text != default_values[3]))
                {
                    if (!webhook_id.Text.StartsWith("https://discord.com/api/webhooks/"))
                    {
                        MessageBox.Show("Please enter a valid Discord Webhook URL");
                    }
                    else if (!profilepic.Text.StartsWith("http"))
                    {
                        MessageBox.Show("Please enter a valid Profile Pic URL");
                    }
                    else
                    {
                        Webhook webhook = new Webhook(webhook_id.Text);
                        WebhookObject obj = new WebhookObject();
                        obj.username = $"{author.Text}";
                        obj.avatar_url = $"{profilepic.Text}";
                        string video = atch.Text;
                        string image = atch.Text;
                        if (isEmbed.Checked)
                        {
                            obj.embeds = new Embed[]
                            {
                                new Embed()
                                {
                                    image = new DiscordWebhook.Image(){
                                        url = image == default_values[4] ? null : image,
                                    },

                                    thumbnail = new Thumbnail(){
                                        url = thumb.Text == default_values[11] ? null : thumb.Text,
                                    },
                                    footer = new Footer(){
                                        text = footer.Text == default_values[10] ? null : footer.Text,
                                    },
                                    author = new Author(){
                                        name = e_author.Text == default_values[9] ? null : e_author.Text,
                                    },

                                    title = title.Text == default_values[6] ? null : title.Text,
                                    description = desc.Text == default_values[6] ? null : desc.Text,
                                    url = url.Text == default_values[11] ? null : url.Text,
                                    color = color.Text == default_values[8] ? 109819 : int.Parse(color.Text),
                                }
                            };
                        }
                        else
                        {
                            obj.content = $"{message.Text}";
                        }
                        webhook.PostData(obj);
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkChange();
        }

        public void checkChange()
        {
            title.Enabled = isEmbed.Checked;
            desc.Enabled = isEmbed.Checked;
            color.Enabled = isEmbed.Checked;
            e_author.Enabled = isEmbed.Checked;
            footer.Enabled = isEmbed.Checked;
            thumb.Enabled = isEmbed.Checked;
            url.Enabled = isEmbed.Checked;
            atch.Enabled = isEmbed.Checked;

            message.Enabled = isText.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkChange();
        }
    }
}
