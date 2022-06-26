namespace _2_1_3.属性写法简化对战
{
    class character
    {
        //state
        public string name { get; private set; }
        public int hp { get; private set; }
        public int attack { get; private set; }
        public int defence { get; private set; }
        public int agility { get; private set; }
        public int focus { get; private set; }
        public bool isDead()
        {
            return hp <= 0;
        }
        //method
        public void costHp(int damage)
        {
            Console.WriteLine($"{this.name}受到伤害{damage}");
            hp -= damage;
            if (hp < 0)
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

            int firstHitA = random.Next(0, s1.agility + 10);
            int firstHitB = random.Next(0, s2.agility + 10);
            int godDecision = random.Next(0, 100);
            if (firstHitA > firstHitB)
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
                if (godDecision < 50)
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
        public void causeDamage(character s1, character s2)
        {
            //闪避阶段
            dogeChance = compare(s2.agility, s1.agility);
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
                int superAttackChance = compare(s1.focus, s2.focus);
                int b = random.Next(0, 100);
                if (superAttackChance > b)
                {
                    damage = s1.attack - s2.defence;
                    damage = damage * 2;
                    if (s2.isDead() == false)
                    {
                        Console.WriteLine($"暴击，{s1.name}对{s2.name}造成伤害{damage}！");
                    }
                    s2.costHp(damage);
                }
                else
                {
                    damage = s1.attack - s2.defence;
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
            character s1 = new character("bill", 500, 50, 50, 10, 90);
            character s2 = new character("gates", 100, 100, 5, 30, 20);
            battle battle = new battle();
            Console.WriteLine("bill专注于重量级的训练，长期以来的训练让bill更加专心，同时由于过度的专注肌肉训练，让他丧失了很多的灵巧性");
            Console.WriteLine("gates天天走梅花桩，长期以来的训练让gates更像一名灵巧的刺客，可以应对各种攻击，但过于沉溺技巧让他的身体很单薄，同时也丧失了很多专注");
            while (s1.isDead() == false && s2.isDead() == false)
            {
                Console.WriteLine(s1);
                Console.WriteLine(s2);
                Console.WriteLine();
                battle.firstHit(s1, s2);
                if (s1.isDead() == true)
                {
                    Console.WriteLine($"{s1.name}当前生命是{s1.hp}，{s2.name}当前生命是{s2.hp}");
                    Console.WriteLine($"{s2.name}获得了胜利，game over");
                    break;
                }
                if (s2.isDead() == true)
                {
                    Console.WriteLine($"{s1.name}当前生命是{s1.hp}，{s2.name}当前生命是{s2.hp}");
                    Console.WriteLine($"{s1.name}获得了胜利，game over");
                    break;
                }
            }

        }
    }
}