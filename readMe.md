# Unity 2D Cheatsheet

## MonoDavranış
Sınıf MonoBehaviour, sınıfınızı oyun nesneleri için bir bileşene dönüştürmenize yardımcı olmak amacıyla Unity tarafından tanımlanır:

```c#
using UnityEngine;

public class ExampleClass : MonoBehaviour
{

}

```

## Komut Dosyası Yaşam Döngüsü
Sınıftan türetilen tüm bileşenler, MonoBehaviourönceden belirlenmiş bir sırayla bir dizi olay işlevini yürütür. Bunlar şunlardır:

* Awake()- Bu işlev, bir oyun nesnesi başlatıldıktan sonra çağrılır.
* OnEnable()- Bu işlev, bir oyun nesnesi etkinleştirildiğinde çağrılır.
* Start()- Bu fonksiyon ilk çerçeve güncellemesinden önce çağrılır.
* Update()- Bu fonksiyon her karede çağrılır.
* LateUpdate()- Bu fonksiyon, fonksiyon çağrıldıktan sonraki her karede çağrılır .Update()
* OnBecameVisible()- Bu işlev, geçerli oyun nesnesi herhangi bir kamera aracılığıyla görünür hale geldiğinde çağrılır.
* OnBecameInvisible()- Bu işlev, mevcut oyun nesnesi artık herhangi bir kamera tarafından görülemediğinde çağrılır.
* OnDrawGizmos()- Bu işlev, sahne penceresinde aygıtların çizilmesi için çağrılır .
* OnGUI()- Bu işlev GUI olayları için birden çok kez çağrılır.
* OnApplicationPause()- Bu işlev, oyun Unity editörü aracılığıyla duraklatıldığında çağrılır.
* OnDisable()- Bu işlev oyun nesnesi devre dışı bırakıldığında çağrılır.
* OnDestroy()- Bu işlev, oyun nesnesi yok edildiğinde çağrılır.
* FixedUpdateSaniyede sabit sayıda kez olarak adlandırılan, adında bir yaşam döngüsü işlevi vardır . Frekansı Düzenle ▸ Proje Ayarları ▸ Zaman ▸ Sabit Zaman Adımı'nda yapılandırabilirsiniz .


## Değişkenleri Serileştirme
Unity, değişkenleriniz üzerinde serileştirme yapma yeteneğine sahiptir. Serileştirme, verilerinizi Unity editöründen okunabilecek ve düzenlenebilecek bir formata dönüştürme işlemidir. Değişkenler, bir değişkene uygulanan öznitelik veya erişim değiştiricilere göre serileştirilebilir.

__ ___ ___ ___

Bir değişken ise public otomatik olarak serileştirilir:

```c#
public int age = 10;
```

Genel değişkenlerin serileştirilmesini istemiyorsanız, ad NonSerializedalanındaki özniteliği Systemşu şekilde kullanabilirsiniz:

```c#
[NonSerialized] public int age = 10;
```

Özel değişkenler serileştirilmedi. Ancak bunların serileştirilmesini istiyorsanız Unity'nin SerializeFieldad alanından bulunabilen bir özelliği vardır Unity. Şu şekilde uygulanabilir:

```c#
[SerializeField] private int age = 10;
```

## Oyun Nesnelerini Örnekleme
İşlev çağrılarak programlı olarak sahneye yeni oyun nesneleri eklenebilir Instantiate(). Bu fonksiyonun üç argümanı vardır.

* Oyun Nesnesi 
* (İsteğe bağlı) Küresel Konum
* (İsteğe bağlı) Döndürme

```c#

Instantiate(someGameObject);
Instantiate(someGameObject, new Vector3(0, 0, 10));
Instantiate(someGameObject, new Vector3(0, 0, 10), Quaternion.identity);
```

## Bileşenler

Oyun nesneleri kendi başlarına hiçbir şey yapamazlar. Belirli işlevler eklemek için bileşenler eklemeliyiz. Özel bileşenler eklerseniz diğer bileşenleri seçmek isteyebilirsiniz. Unity, bir oyun nesnesinden bileşenleri almak için çeşitli çözümler sunar.

İlk çözüm işlevi kullanmaktır GetComponent(). Bu işlevi çağırmanın farklı yolları vardır. En yaygın olanı, bileşene ilişkin sınıfın adını şu şekilde genel olarak iletmektir:

```c#
AudioSource audioSource = GetComponent<AudioSource>();
```

Alternatif olarak, anahtar kelimeyi kullanabilir typeofve değeri şu şekilde belirtebilirsiniz:

```c#
AudioSource audioSource = GetComponent(typeof(AudioSource)) as AudioSource;
```

Son olarak bileşenin adını şu şekilde bir dize olarak iletebilirsiniz:

```c#
AudioSource audioSource = GetComponent("AudioSource") as AudioSource;
```

## Vektörler

Vektörler oyun nesnelerinin konumları için kullanılır. Mesafeyi ve hareketi hesaplamanıza yardımcı olması için bunları kullanabilirsiniz. Vector2ve olmak üzere iki vektör sınıfı vardır Vector3

Vektör 3

```c#

Vector3.right   /* (1, 0, 0)  */
Vector3.left    /* (-1, 0, 0) */
Vector3.up      /* (0, 1, 0)  */
Vector3.down    /* (0, -1, 0) */
Vector3.forward /* (0, 0, 1)  */
Vector3.back    /* (0, 0, -1) */
Vector3.zero    /* (0, 0, 0)  */
Vector3.one     /* (1, 1, 1)  */

```

Vektör2

```c#
Vector2.right /* (1, 0)  */
Vector2.left  /* (-1, 0) */
Vector2.up    /* (0, 1)  */
Vector2.down  /* (0, -1) */
Vector2.zero  /* (0, 0)  */
Vector2.one   /* (1, 1)  */

```
Belirli bir vektörün yönü ile ilgileniyorsanız, onun normalizedözelliğine şu şekilde erişebilirsiniz:

```c#

myVector.normalized

```
