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
2способ

                private void button1_Click(object sender, EventArgs e)
                        {
                            using (Model1 db = new Model1())
                            {
                                var orgs = (from org in db.Org
                                            where org.Login == textBox1.Text && org.Password == textBox2.Text
                                            select org).FirstOrDefault();
                                
                                if(orgs != null)
                                {
                                    OrgForm frm = new OrgForm();
                                    frm.ShowDialog();
                                }
                                else
                                {
                                    var moders = (from moder in db.Moder
                                                where moder.Login == textBox1.Text && moder.Password == textBox2.Text
                                                select moder).FirstOrDefault();
                                    
                                    if (moders != null)
                                    {
                                        ModerForm moderForm =new ModerForm();
                                        moderForm.ShowDialog();
                                    }
                                    else
                                    {
                                        var zuris = (from zuri in db.Zuri
                                                    where zuri.Login == textBox1.Text && zuri.Password == textBox2.Text
                                                    select zuri).FirstOrDefault();
                                        
                                        if (zuris != null)
                                        {
                                            ZuriForm zuriForm = new ZuriForm();
                                            zuriForm.ShowDialog();
                                        }
                                        else
                                        {
                                            var users = (from user in db.User
                                                        where user.Login == textBox1.Text && user.Password == textBox2.Text
                                                        select user).FirstOrDefault();
                                            
                                            if (users != null)
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




1 Введение
1.1 Область применения
1.2 Краткое описание возможностей
1.3 Уровень подготовки пользователя
1.4 Перечень эксплуатационной документации, с которыми необходимо ознакомиться пользователю
2 Назначение и условия применения
2.1 Виды деятельности, функции, для автоматизации которых предназначено данное средство автоматизации
2.2 Условия, при соблюдении (выполнении, наступлении) которых обеспечивается применение средства автоматизации в соответствии с назначением (например, вид ЭВМ и конфигурация технических средств, операционная среда и общесистемные программные средства, входная информация, носители данных, база данных, требования к подготовке специалистов и т. п.)
3 Подготовка к работе
3.1 Состав и содержание дистрибутивного носителя данных
3.2 Порядок загрузки данных и программ
3.3 Порядок проверки работоспособности
4 Описание операций
4.1 Описание всех выполняемых функций, задач, комплексов задач, процедур
4.2 Описание операций технологического процесса обработки данных, необходимых для выполнения функций, комплексов задач (задач), процедур
4.2.1 Наименование операции
4.2.2 Условия, при соблюдении которых возможно выполнение операции
4.2.3 Подготовительные действия
4.2.4 Основные действия в требуемой последовательности
4.2.5 Заключительные действия
4.2.6 Ресурсы, расходуемые на операцию
5 Аварийные ситуации
5.1 Действия в случае несоблюдения условий выполнения технологического процесса, в том числе при длительных отказах технических средств
5.2 Действия по восстановлению программ и/или данных при отказе магнитных носителей или обнаружении ошибок в данных
5.3 Действия в случаях обнаружении несанкционированного вмешательства в данные
5.4 Действия в других аварийных ситуациях
6 Рекомендации к освоению
Содержание документов является общим для всех видов АС и, при необходимости, может дополняться разработчиком документов в зависимости от особенностей создаваемой АС. Допускается включать в документы дополнительные разделы и сведения, объединять и исключать разделы.

Содержание документов, разрабатываемых на предпроектных стадиях по ГОСТ 34.601, и организационно-распорядительных определяют разработчики в зависимости от объема информации, необходимой и достаточной для дальнейшего использования документов.




