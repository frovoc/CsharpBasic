namespace _2_1_2.拳击手对战
{
    class character
    {
        //state
        public string name;
        private int hp;
        private int attack;
        private int defence;
        private int agility;
        private int focus;
        public bool isDead()
        {
            return hp <= 0;
        }
        public int getHp()
        {
            return hp;
        }
        public int getAttack()
        {
            return attack;
        }
        public int getDefence()
        {
            return defence;
        }
        public int getAgility()
        {
            return agility;
        }
        public int getFocus()
        {
            return this.focus;
        }
        //method
        public void costHp(int damage)
        {
            Console.WriteLine($"{this.name}受到伤害{damage}");
            hp -= damage;
            if (hp<0)
            {
                hp = 0;
                Console.WriteLine($"{this.name}受到致命一击 伤害{damage}！，当前生命{this.hp},{this.name} 死了");
                isDead();
            }
        }
        public override string ToString()
        {
            return $"{name},生命值{hp},攻击力{attack},防御力{defence},敏捷{agility},专注{focus}";
        }
        public character()
        {
        }
        public character(string name, int hp, int attack, int defence, int agility, int focus)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.defence = defence;
            this.agility = agility;
            this.focus = focus;
        }
        public character(string name)
        {
            this.name = name;
            this.hp = 100;
            this.attack = 10;
            this.defence = 1;
            this.agility = 1;
            this.focus = 1;
        }
    }
    class battle
    {       
        private int damage;
        private int dogeChance;
        private int firstHitChance;
        static int compare(int a, int b)
        {
            if (a - b > 0)
            {
                return a - b;
            }
            else
            {
                return 0;
            }
        }
        public void firstHit(character s1, character s2)
        {
            Random random = new Random();
            
            int firstHitA = random.Next(0,s1.getAgility()+10);
            int firstHitB = random.Next(0,s2.getAgility()+10);
            int godDecision = random.Next(0, 100);
            if (firstHitA >firstHitB)
            {
                Console.WriteLine($"{s1.name}更加敏捷，抢先出手！");
                causeDamage(s1, s2);
            }
            else if (firstHitA < firstHitB)
            {
                Console.WriteLine($"{s2.name}更加敏捷，抢先出手！");
                causeDamage(s2, s1);
            }
            else
            {
                if (godDecision<50)
                {
                    Console.WriteLine($"上帝眷顾{s1.name}抢先出手！");
                    causeDamage(s1, s2);
                }
                else
                {
                    Console.WriteLine($"上帝眷顾{s2.name}抢先出手！");
                    causeDamage(s2, s1);
                }
            }
        }      
        public void causeDamage(character s1,character s2)
        {
            //闪避阶段
            dogeChance = compare(s2.getAgility(), s1.getAgility());
            Random random = new Random();
            int a = random.Next(0, 100);
            if (dogeChance > a)
            {
                damage = 0;
                Console.WriteLine($"{s2.name}灵巧的闪避了这次攻击，miss");
                s2.costHp(damage);  
            } 
            else //伤害及暴击计算阶段
            {
                int superAttackChance = compare(s1.getFocus() , s2.getFocus());
                int b = random.Next(0, 100);
                if (superAttackChance > b)
                {
                    damage = s1.getAttack() - s2.getDefence();
                    damage = damage * 2;
                    if (s2.isDead() == false)
                    {
                        Console.WriteLine($"暴击，{s1.name}对{s2.name}造成伤害{damage}！");
                    }
                    s2.costHp(damage);                }
                else
                {
                    damage = s1.getAttack() - s2.getDefence();
                    if (s2.isDead() == false)
                    {
                        Console.WriteLine($"{s1.name}对{s2.name}造成伤害{damage}");
                    }
                    s2.costHp(damage);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1、模拟两个拳击手，它们至少有生命值（Hp）和攻击力（Attack）这两个字段。让它们来回攻击对方，直到一方被打倒。
            2、进一步，为他们实现特殊的被动技能，比如战败后复活（限定1次）、愤怒（生命值低于一定程度攻击力翻倍），闪避（一定概率不受伤害）等等。
            （选作）能否实现更多有趣的主动技能？
            3、在你的代码中，尽量用上“构造函数”和“访问控制”，改进你的代码。
            4、思考：能用上“静态”语法吗？
             */
            character bill = new character("bill",500,50,50,10,90);
            character gates = new character("gates",100,100,5,30,20);
            battle battle = new battle();

            character s1 = bill;
            character s2 = gates;

            Console.WriteLine("bill专注于重量级的训练，长期以来的训练让bill更加专心，同时由于过度的专注肌肉训练，让他丧失了很多的灵巧性");
            Console.WriteLine("gates天天走梅花桩，长期以来的训练让gates更像一名灵巧的刺客，可以应对各种攻击，但过于沉溺技巧让他的身体很单薄，同时也丧失了很多专注");
            while (s1.isDead()==false && s2.isDead()==false)
            {
                Console.WriteLine(s1);
                Console.WriteLine(s2);
                Console.WriteLine();
                battle.firstHit(s1, s2);
                if (s1.isDead() == true)
                {
                    Console.WriteLine($"{s1.name}当前生命是{s1.getHp()}，{s2.name}当前生命是{s2.getHp()}");
                    Console.WriteLine($"{s2.name}获得了胜利，game over");
                    break;
                }
                if (s2.isDead() == true)
                {
                    Console.WriteLine($"{s1.name}当前生命是{s1.getHp()}，{s2.name}当前生命是{s2.getHp()}");
                    Console.WriteLine($"{s1.name}获得了胜利，game over");
                    break;
                }
            }
            
        }
    }
}