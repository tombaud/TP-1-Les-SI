using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Boucle générale pour revenir au menu de séléction à la fin d'un exercice (Les classes ca marche aussi mais comme ça le code source est plus long)
            {
                int choix;
                string retourMenu = string.Empty;

                Console.WriteLine("Exercice 1 : Moyenne BTS SIO");
                Console.WriteLine("Exercice 2 : La franchise de mon assurance");
                Console.WriteLine("Exercice 3 : Les états de l'eau");
                Console.WriteLine("Exercice 4 : Equation du second degré");
                Console.WriteLine("Exercice 5 : IMC et interprétation");
                Console.WriteLine("Exercice 6 : Bonjour, c'est le week-end");

                while (true)
                {
                    try
                    {
                        Console.WriteLine();
                        Console.WriteLine("Veuillez renseiner le numéro de votre choix pour accéder à l'exercice associé");
                        choix = int.Parse(Console.ReadLine());
                        if(choix < 1 || choix > 7)
                        {
                            Console.WriteLine("Veuillez renseigner un numéro correct");
                            continue;
                        }
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }

                if (choix == 1)
                {
                    Console.Clear();
                    double noteCultureGeneral;
                    double noteExpressionCommunication;
                    double noteMathematiques;
                    double noteEconomie;
                    double noteInformatique;
                    double noteDevelopment;
                    double noteCyberSecurite;

                    while (true)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseiner la note de culture generale et expression : ");
                                noteCultureGeneral = int.Parse(Console.ReadLine());
                                if (noteCultureGeneral > 20)
                                {
                                    Console.WriteLine("Veuillez renseigner une note correcte");
                                    continue;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner une note correcte");
                                continue;
                            }
                            break;
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseiner la note d'expression communication : ");
                                noteExpressionCommunication = int.Parse(Console.ReadLine());
                                if (noteExpressionCommunication > 20)
                                {
                                    Console.WriteLine("Veuillez renseigner une note correcte");
                                    continue;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner une note correcte");
                                continue;
                            }
                            break;
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseiner la note de Mathématiques : ");
                                noteMathematiques = int.Parse(Console.ReadLine());
                                if (noteMathematiques > 20)
                                {
                                    Console.WriteLine("Veuillez renseigner une note correcte");
                                    continue;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner une note correcte");
                                continue;
                            }
                            break;
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseiner la note d'Economie : ");
                                noteEconomie = int.Parse(Console.ReadLine());
                                if (noteEconomie > 20)
                                {
                                    Console.WriteLine("Veuillez renseigner une note correcte");
                                    continue;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner une note correcte");
                                continue;
                            }
                            break;
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseiner la note de Support & Mise à Disposition de Services Informatiques : ");
                                noteInformatique = int.Parse(Console.ReadLine());
                                if (noteInformatique > 20)
                                {
                                    Console.WriteLine("Veuillez renseigner une note correcte");
                                    continue;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner une note correcte");
                                continue;
                            }
                            break;
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseiner la note de Développement : ");
                                noteDevelopment = int.Parse(Console.ReadLine());
                                if (noteDevelopment > 20)
                                {
                                    Console.WriteLine("Veuillez renseigner une note correcte");
                                    continue;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner une note correcte");
                                continue;
                            }
                            break;
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseiner la note de Cybersécurité : ");
                                noteCyberSecurite = int.Parse(Console.ReadLine());
                                if (noteCyberSecurite > 20)
                                {
                                    Console.WriteLine("Veuillez renseigner une note correcte");
                                    continue;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner une note correcte");
                                continue;
                            }
                            break;
                        }

                        FileStream file = File.Open("./Relevé_de_Notes.txt", FileMode.OpenOrCreate);
                        StreamWriter faisMoiUnTxt = new(file);

                        //Création du fichier texte

                        faisMoiUnTxt.WriteLine("Bulletin de Notes");
                        faisMoiUnTxt.WriteLine();
                        faisMoiUnTxt.WriteLine("CULTURE & COMMUNICATION");
                        faisMoiUnTxt.WriteLine();
                        faisMoiUnTxt.WriteLine("Culture Générale & Expression (Coef 2) : " + noteCultureGeneral);
                        faisMoiUnTxt.WriteLine();
                        faisMoiUnTxt.WriteLine("Expression & Commmunication en langue anglaise (Coef 2) : " + noteExpressionCommunication);
                        faisMoiUnTxt.WriteLine();
                        faisMoiUnTxt.WriteLine("Mathématiques pour l'informatique (Coef 3) : " + noteMathematiques);
                        faisMoiUnTxt.WriteLine();
                        faisMoiUnTxt.WriteLine("Culture Juridique Economique & Managériale pour l'informatique (Coef 3) : " + noteEconomie);
                        faisMoiUnTxt.WriteLine();
                        faisMoiUnTxt.WriteLine("Support & Mise à disposition de services informatiques (Coef 4) : " + noteInformatique);
                        faisMoiUnTxt.WriteLine();
                        faisMoiUnTxt.WriteLine("Conception & Développement d'Applications (Coef 4) : " + noteDevelopment);
                        faisMoiUnTxt.WriteLine();
                        faisMoiUnTxt.WriteLine("Cybersécurité des Services Informatiques (Coef 4) : " + noteCyberSecurite);

                        faisMoiUnTxt.Close();
                        file.Close();

                        noteCultureGeneral = noteCultureGeneral * 2;
                        noteMathematiques = noteMathematiques * 3;
                        noteEconomie = noteEconomie * 3;
                        noteInformatique = noteInformatique * 4;
                        noteDevelopment = noteDevelopment * 4;
                        noteExpressionCommunication = noteExpressionCommunication * 2;
                        noteCyberSecurite = noteCyberSecurite * 4;

                        double moyenneBts = noteCyberSecurite + noteCultureGeneral + noteDevelopment + noteEconomie + noteExpressionCommunication + noteMathematiques + noteCultureGeneral;
                        moyenneBts = moyenneBts / 29;

                        Console.WriteLine("Votre moyenne est de : " + moyenneBts + " points");

                        if (moyenneBts < 10)
                        {
                            Console.WriteLine("Vous avez une moyenne insuffisante pour obtenir votre diplôme");

                            if (noteCyberSecurite > 10)
                            {
                                Console.WriteLine("Vous pouvez conserver vos résultats de Cybersécurité des services informatiques pour l'année prochaine");
                            }

                            if (noteCultureGeneral > 10)
                            {
                                Console.WriteLine("Vous pouvez conserver vos résultats de Culture Générale & Expression pour l'année prochaine");
                            }

                            if (noteExpressionCommunication > 10)
                            {
                                Console.WriteLine("Vous pouvez conserver vos résultats d'Expression & Communication en langue anglaise pour l'année prochaine");
                            }

                            if (noteDevelopment > 10)
                            {
                                Console.WriteLine("Vous pouvez conserver vos résultats de Developpement d'applications pour l'année prochaine");
                            }

                            if (noteInformatique > 10)
                            {
                                Console.WriteLine("Vous pouvez conserver vos résultats de Support & mise a disposition de services informatiques pour l'année prochaine");
                            }

                            if (noteMathematiques > 10)
                            {
                                Console.WriteLine("Vous pouvez conserver vos résultats de Mathématiques pour l'informatique pour l'année prochaine");
                            }

                            if (noteEconomie > 10)
                            {
                                Console.WriteLine("Vous pouvez conserver vos résultats d'Economie pour l'année prochaine");
                            }
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Voulez vous retourner au menu de séléction ? (O/N)");
                                retourMenu = (Console.ReadLine());
                                retourMenu.ToUpper();
                                if (retourMenu != "O" && retourMenu != "N")
                                {
                                    Console.WriteLine("Veuillez renseigner une réponse correcte");
                                    continue;
                                }
                                break;
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Veuillez renseigner une réponse correcte");
                                continue;
                            }
                        }
                        if(retourMenu == "O")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }


                }
                if (choix == 2)
                {
                    double montantDommages;
                    double montantRefunded;
                    double montantNotRefunded;

                    while (true)
                    {
                        Console.Clear();

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Bonjour, veuillez saisir le montant des dommages. Rappel, ce montant ne doit pas excéder 40 000 € : ");
                                montantDommages = int.Parse(Console.ReadLine());

                                if (montantDommages > 40000 || montantDommages < 0)
                                {
                                    Console.WriteLine("Veuillez renseigner un montant correct");
                                    continue;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner un montant correct");
                                continue;
                            }
                            break;
                        }

                        montantNotRefunded = montantDommages * 0.10;
                        montantRefunded = montantDommages - montantNotRefunded;

                        Console.WriteLine("Pour un montant de : " + montantDommages + " euros");
                        Console.WriteLine("Vous serez remboursé de : "+ montantRefunded + " euros");
                        Console.WriteLine("Vous aurez : " + montantNotRefunded + " euros de franchise");

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Voulez vous retourner au menu de séléction ? (O/N)");
                                retourMenu = (Console.ReadLine());
                                retourMenu.ToUpper();
                                if (retourMenu != "O" && retourMenu != "N")
                                {
                                    Console.WriteLine("Veuillez renseigner une réponse correcte");
                                    continue;
                                }
                                break;
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Veuillez renseigner une réponse correcte");
                                continue;
                            }
                        }
                        if (retourMenu == "O")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                if(choix == 3)
                {
                    double temperatureEau;

                    while (true)
                    {
                        Console.Clear();

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseigner la température de l'eau");
                                temperatureEau = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner une valeur correcte");
                                continue;
                            }
                            break;
                        }

                        if (temperatureEau < 0)
                        {
                            Console.WriteLine("L'eau est à l'état de glace");
                        }
                        if (temperatureEau >= 0 && temperatureEau <= 100)
                        {
                            Console.WriteLine("L'eau est à l'état liquide");
                        }
                        if (temperatureEau > 100)
                        {
                            Console.WriteLine("L'eau est à l'état gazeux");
                        }
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Voulez vous retourner au menu de séléction ? (O/N)");
                                retourMenu = (Console.ReadLine());
                                retourMenu.ToUpper();
                                if (retourMenu != "O" && retourMenu != "N")
                                {
                                    Console.WriteLine("Veuillez renseigner une réponse correcte");
                                    continue;
                                }
                                break;
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Veuillez renseigner une réponse correcte");
                                continue;
                            }
                        }
                        if (retourMenu == "O")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                    }
                }
                if (choix == 4)
                {

                    Console.Clear();

                    double nombreA;
                    double nombreB;
                    double nombreC;
                    double delta;

                    while (true)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseigner la valeur du nombre A");
                                nombreA = double.Parse(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner un chiffre correct");
                                continue;
                            }
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseigner la valeur du nombre B");
                                nombreB = double.Parse(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner un chiffre correct");
                                continue;
                            }
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseigner la valeur du nombre C");
                                nombreC = double.Parse(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner un chiffre correct");
                                continue;
                            }
                        }

                        delta = Math.Pow(nombreB, 2) - 4 * nombreA * nombreC;

                        if(delta > 0)
                        {
                            Console.WriteLine("Deux solutions sont possibles, les voici :");
                            Console.WriteLine();
                            Console.WriteLine("X1 = " + (- nombreB + Math.Sqrt(delta)) / (2 * nombreA));
                            Console.WriteLine();
                            Console.WriteLine("X2 = " + (-nombreB - Math.Sqrt(delta)) / (2 * nombreA));
                        }
                        else if(delta < 0)
                        {
                            Console.WriteLine("Aucune solution n'est possible");
                        }
                        else
                        {
                            Console.WriteLine("Une seule solution est possible, la voici : ");
                            Console.WriteLine();
                            Console.WriteLine("X = " + -nombreB / (2 * nombreA));
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Voulez vous retourner au menu de séléction ? (O/N)");
                                retourMenu = (Console.ReadLine());
                                retourMenu.ToUpper();
                                if (retourMenu != "O" && retourMenu != "N")
                                {
                                    Console.WriteLine("Veuillez renseigner une réponse correcte");
                                    continue;
                                }
                                break;
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Veuillez renseigner une réponse correcte");
                                continue;
                            }
                        }
                        if (retourMenu == "O")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                    }
                }
                if (choix == 5)
                {
                    Console.Clear();

                    int poids;
                    double taille;
                    double IMC;

                    while (true)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseigner votre poids :");
                                poids = int.Parse(Console.ReadLine());
                                if (poids > 200 || poids < 30)
                                {
                                    Console.WriteLine("Veuillez renseigner un poids compris entre 30 & 200");
                                    continue;
                                }
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner un poids correct");
                                continue;
                            }
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Veuillez renseigner votre taille : ");
                                taille = int.Parse(Console.ReadLine());
                                if (taille > 3 || taille < 1)
                                {
                                    Console.WriteLine("Veuillez renseigner une taille entre 1 & 3 mètres");
                                    continue;
                                }
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Veuillez renseigner une taille correcte");
                                continue;
                            }
                        }

                        taille = Math.Pow(taille, 2);
                        IMC = poids / taille;

                        if(IMC < 16.5)
                        {
                            Console.WriteLine("Vous possédez un IMC de : " + IMC + " et êtes en état de dénutrition");
                        }
                        if(IMC >= 16.5 && IMC <= 18.5)
                        {
                            Console.WriteLine("Vous possédez un IMC de : " + IMC + " et êtes en état de maigreur");
                        }
                        if(IMC >= 18.5 && IMC <= 25)
                        {
                            Console.WriteLine("Vous possédez un IMC de : " + IMC + " et êtes de corpulence normale");
                        }
                        if(IMC >= 25 && IMC <= 30)
                        {
                            Console.WriteLine("Vous possédez un IMC de : " + IMC + " et êtes en état de surpoids");
                        }
                        if(IMC >= 30 && IMC <= 35)
                        {
                            Console.WriteLine("Vous possédez un IMC de : " + IMC + " et êtes en état d'obésité modérée");
                        }
                        if(IMC >= 35 && IMC <= 40)
                        {
                            Console.WriteLine("Vous possédez un IMC de : " + IMC + " et êtes en état d'obésité sévère");
                        }
                        if(IMC >= 40)
                        {
                            Console.WriteLine("Vous possédez un IMC de : " + IMC + " et êtes en état d'obésité morbide");
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Voulez vous retourner au menu de séléction ? (O/N)");
                                retourMenu = (Console.ReadLine());
                                retourMenu.ToUpper();
                                if (retourMenu != "O" && retourMenu != "N")
                                {
                                    Console.WriteLine("Veuillez renseigner une réponse correcte");
                                    continue;
                                }
                                break;
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Veuillez renseigner une réponse correcte");
                                continue;
                            }
                        }
                        if (retourMenu == "O")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }
                    }
                }
                if (choix == 6)
                {
                    Console.Clear();

                    string nomUtilisateur = Environment.UserName;
                    int heure = DateTime.Now.Hour;
                    DayOfWeek journee = DateTime.Now.DayOfWeek;

                    while (true)
                    {
                        if (journee == DayOfWeek.Monday || journee == DayOfWeek.Tuesday || journee == DayOfWeek.Wednesday || journee == DayOfWeek.Thursday)
                        {
                            if (heure <= 9 || heure >= 18)
                            {
                                Console.WriteLine("Bonsoir " + nomUtilisateur + " il est : " + heure + " H, nous sommes le : " + journee + " bonne semaine & courage !");
                            }
                            else
                            {
                                Console.WriteLine("Bonjour " + nomUtilisateur + " il est : " + heure + "H, nous sommes le : " + journee + " bonne semaine & courage !");
                            }
                        }
                        if (journee == DayOfWeek.Friday)
                        {
                            if (heure <= 9 || heure >= 18)
                            {
                                Console.WriteLine("Bonsoir " + nomUtilisateur + " il est : " + heure + " H, nous sommes le : " + journee + " Bon Week-End !");
                            }
                            else
                            {
                                Console.WriteLine("Bonjour " + nomUtilisateur + " il est : " + heure + "H, nous sommes le : " + journee + " bonne fin de semaine & courage !");
                            }
                        }

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Voulez vous retourner au menu de séléction ? (O/N)");
                                retourMenu = (Console.ReadLine());
                                retourMenu.ToUpper();
                                if (retourMenu != "O" && retourMenu != "N")
                                {
                                    Console.WriteLine("Veuillez renseigner une réponse correcte");
                                    continue;
                                }
                                break;
                            }
                            catch
                            {
                                Console.Clear();
                                Console.WriteLine("Veuillez renseigner une réponse correcte");
                                continue;
                            }
                        }
                        if (retourMenu == "O")
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            continue;
                        }

                    }
                }
            }
        }
    }
}
