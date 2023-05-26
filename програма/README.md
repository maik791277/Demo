# Code


1.
кнопка авторизации


                private void button1_Click(object sender, EventArgs e)
                        {
                            using (Model1 db = new Model1())
                            {
                                var users = (from user in db.Org
                                            where user.Login == textBox1.Text && user.Password == textBox2.Text
                                            select user).ToList();
                                var das = users.Count;
                                if(das == 1)
                                {
                                    OrgForm frm = new OrgForm();
                                    frm.ShowDialog();
                                }
                                else
                                {
                                    var users1 = (from user1 in db.Moder
                                                where user1.Login == textBox1.Text && user1.Password == textBox2.Text
                                                select user1).ToList();
                                    var das1 = users1.Count;
                                    if (das1 == 1)
                                    {
                                        ModerForm moderForm =new ModerForm();
                                        moderForm.ShowDialog();
                                    }
                                    else
                                    {
                                        var users2 = (from user in db.Zuri
                                                    where user.Login == textBox1.Text && user.Password == textBox2.Text
                                                    select user).ToList();
                                        var das2 = users.Count;
                                        if (das2 == 1)
                                        {
                                            ZuriForm zuriForm = new ZuriForm();
                                            zuriForm.ShowDialog();
                                        }
                                        else
                                        {
                                            var users3 = (from user in db.User
                                                        where user.Login == textBox1.Text && user.Password == textBox2.Text
                                                        select user).ToList();
                                            var das3 = users.Count;
                                            if (das3 == 1)
                                            {
                                                UserForm userForm = new UserForm();
                                                userForm.ShowDialog();
                                            }
                                        }
                                    }
                                } 


                            }
                            
                        }

2.