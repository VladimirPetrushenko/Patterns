using Composite.Emails;
using Composite.FileSystems;

namespace Composite
{
    public class MainComposite
    {
        public static void Make()
        {
            var folder = new Folder("C")
                .AddItems(new Folder("Windows")
                    .AddItems(new Folder("System32")
                        .AddItems(new File("system.xml"),
                        new Folder("Driver")
                            .AddItems(new Folder("ect")
                                .AddItems(new File("ip.json"),
                                new Folder("ect2"))
                                )
                            )
                        )
                    );
            folder.PrintInfo(" ");

            var Vladimir = new Email("Vladimir");
            var Vasiliy = new Email("Vasiliy");
            var Anna = new Email("Anna");
            var Viktoriya = new Email("Viktorian");
            var Mothers = new Email("Mothers");

            var newYearGroup = new Group("New Year Group", Vladimir, Vasiliy, Anna, Viktoriya);

            newYearGroup.Send("Present for mother");
            
            newYearGroup.Append(Mothers);
            newYearGroup.Send("Hello");
        }
    }
}
