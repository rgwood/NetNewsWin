using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetNewsWin
{
    public class Repository
    {
        public static ObservableCollection<Entry> GetTestEntries()
        {
            return new ObservableCollection<Entry>
            {
                new Entry(1, "Foo", "Jason Kottke", LoremIpsum),
                new Entry(2, "Bar", "Mike Mitchum", LoremIpsum)
            };
        }

        private static readonly string LoremIpsum = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu vulputate mi. Aenean interdum felis vitae aliquet tempus. Fusce efficitur dignissim eros, ac sollicitudin massa blandit sed. Vestibulum luctus ex nec nisi ullamcorper dapibus semper id lacus. Pellentesque sed massa at tortor convallis gravida. Sed a eleifend mauris. Donec ex ex, scelerisque eget tincidunt at, dictum accumsan est. Nulla a ipsum condimentum, fringilla tortor vel, laoreet magna. Integer eleifend lacus non accumsan porttitor. Nulla quis tortor eu sem luctus elementum vel ut tortor. In dignissim neque quis nisi posuere ultrices.

Phasellus et pulvinar ipsum. Quisque ullamcorper ante malesuada, pulvinar felis eu, rutrum est. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus dapibus dui eu vehicula imperdiet. Aliquam vel facilisis erat, nec tristique metus. Etiam ut sapien ut ex faucibus lobortis. Etiam purus lacus, mollis non auctor in, iaculis ac ex. Sed ultrices imperdiet nisi, eu blandit ligula congue id. Quisque iaculis ultrices est ut placerat. Suspendisse dignissim vestibulum nibh vitae commodo. Nunc vitae venenatis ante. Aliquam ut quam ultrices, mollis lectus ac, rhoncus neque. Cras purus erat, faucibus eu elit sit amet, maximus pretium lectus. Integer venenatis sem magna.

In eget sem ac magna blandit suscipit. Sed at scelerisque nulla. Nam accumsan nec lectus vitae iaculis. Quisque a vehicula arcu, id dictum est. Pellentesque mattis urna consectetur, lacinia nulla vel, dictum sem. Nulla id lectus mollis, fermentum lorem sit amet, semper massa. Proin vitae placerat mi. Integer ut bibendum nunc. Integer lacinia magna id enim scelerisque, vel tempus tortor dictum. Curabitur varius nisl in blandit posuere. Nulla at lobortis nisl, vel mattis sem. Interdum et malesuada fames ac ante ipsum primis in faucibus.

Proin eu dolor nec sapien malesuada finibus. Nullam placerat dui rhoncus ligula finibus scelerisque. Vestibulum ut pellentesque tellus. Aliquam quis ex sit amet lorem lacinia elementum. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Sed at massa diam. Aenean ornare lectus at gravida dignissim. Curabitur non aliquam nibh. Donec purus nisl, tincidunt id bibendum id, pretium vitae massa. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin luctus auctor porttitor. Sed vestibulum consectetur varius. Aenean vel ullamcorper diam, sit amet euismod eros.

Nam laoreet pretium ipsum ac finibus. Phasellus quis tristique nisi. Vestibulum et fringilla risus, nec faucibus leo. Curabitur vel ex vel nunc semper pulvinar ac nec urna. Nullam et lacinia ipsum. Aenean aliquam interdum nunc. Nam vehicula urna nec maximus venenatis. Mauris iaculis metus nulla, ut cursus arcu accumsan nec. Etiam tempor odio eget iaculis tempus. Fusce interdum eget velit ac pretium. In finibus tempus ipsum vitae ultricies. In a commodo velit. Ut commodo tortor pulvinar felis sodales dictum. Vestibulum cursus elit ut justo molestie tincidunt. Nunc at scelerisque augue. Mauris sed orci at mi ultricies efficitur.";
    }
}
