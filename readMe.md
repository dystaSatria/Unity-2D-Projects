# Unity 2D Cheatsheet

## Sahne görünümü
Sahne görünümü, Editör'de oluşturduğunuz dünyayı görselleştirdiğiniz ve onunla etkileşim kurduğunuz yerdir. Sahne görünümünde manzara, karakter, kamera, ışık ve daha fazlası gibi davranan GameObject'leri seçebilir, değiştirebilir ve değiştirebilirsiniz.

## Denetçi(Inspektor ) penceresi
Unity Editor'daki hemen hemen her şeyin özelliklerini ve ayarlarını görüntülemek ve düzenlemek için Denetçi (Inspektor) penceresini kullanın .Oyun Nesneleri
,Unity bileşenleri, Varlıklar, Malzemeler ve Editör içi ayarlar ve tercihler.
## Hiyerarşi

Hiyerarşi penceresi her şeyi görüntülerOyun Nesnesi modeller, Kameralar veya gibi bir SahnedePrefabrikler

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
  FixedUpdate her karede çağrılmaz, ancak sabit zaman aralıklarında çağrılır, bu nedenle tüm kodların buraya yerleştirilmesi gerekmez—sadece fizikle ilgili olan veya tutarlı zaman güncellemeleri gerektiren kodlar burada yer almalıdır.


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

## Kuaterniyon

Oyun nesnesinin döndürülmesi için kuaterniyonlar kullanılır. Mevcut oyun nesnesinin rotasyonu özellik aracılığıyla okunabilir/güncellenebilir transform.rotation.

Unity'nin adında bir işlevi var Quaternion.LookRotation(). Bu işlev, bir vektörü alan bir Kuaterniyon döndürür. Tipik olarak vektör, bakmak istediğiniz oyun nesnesinin konumu olacaktır.

```c#
Quaternion.LookRotation(gameObjectPosition);
```

## Fizik Etkinlikleri

* OnCollisionEnter- Bu işlev, başka bir nesne mevcut oyun nesnesine çarptığında bir kez çağrılır.
* OnCollisionStay- Bu işlev, mevcut oyun nesnesine başka bir nesne çarptığında her karede çağrılır.
* OnCollisionExit- Bu işlev, bir nesne mevcut nesnenin çarpışma bölgesinden çıktığında bir kez çağrılır.

Son olarak 2 boyutlu çarpıştırıcılar için karşılık gelen işlevler vardır. İşlevler, 3B işlevlerle aynı adı paylaşır ancak sözcüğün 2Dsonuna eklenir. Aynı şey parametre türü için de geçerlidir. Bunun Collision2Dyerine Collision.

```c#
private void OnCollisionEnter2D(Collision2D hit) {
  Debug.Log($"{gameObject.name} hits {hit.gameObject.name}");
}
private void OnCollisionStay2D(Collision2D hit) {
  Debug.Log($"{gameObject.name} is hitting {hit.gameObject.name}");
}
private void OnCollisionExit2D(Collision2D hit) {
  Debug.Log($"{gameObject.name} stopped hitting {hit.gameObject.name}");
}
private void OnTriggerEnter2D(Collision2D hit) {
  Debug.Log($"{gameObject.name} hits {hit.gameObject.name}");
}
private void OnTriggerStay2D(Collision2D hit) {
  Debug.Log($"{gameObject.name} is hitting {hit.gameObject.name}");
}
private void OnTriggerExit2D(Collision2D hit) {
  Debug.Log($"{gameObject.name} stopped hitting {hit.gameObject.name}");
}

```

Özetle, OnCollisionEnter2D fiziksel etkileşimler için kullanılırken, OnTriggerEnter2D belirli bir alanda bir nesnenin varlığını fiziksel bir tepki olmaksızın algılamak için daha çok kullanılır.


## Özel Birlik Etkinlikleri
Çeşitli oyun nesneleri arasında iletişim kurmanıza yardımcı olmak için özel etkinlikler oluşturulabilir. Öncelikle doğru ad alanını eklemelisiniz:

```c#
using UnityEngine.Events;
```

UnityEventDaha sonra, aşağıdaki türde bir değişken tanımlayarak özel bir etkinlik oluşturabilirsiniz :

```c#
public event UnityEvent OnCustomEvent;
```

UnityActionUnity'nin özel etkinlikler oluşturmak için adlandırılan başka bir veri türü vardır :

```c#
public event UnityAction OnCustomEvent;
```

Temel fark, türün UnityEventUnity düzenleyicisine serileştirilebilmesidir. Bir etkinliğin Unity editörü aracılığıyla herkese açık olarak değiştirilebilmesine ihtiyacınız yoksa, türü seçmeniz daha iyi olur UnityAction.

Etkinliğinizle birlikte ek veriler göndermek için jenerikleri kullanabilirsiniz. En fazla 4 veri türü desteklenir.

```c#
// 1 Parameter
public event UnityAction<int> OnCustomEvent;
// 2 Parameters
public event UnityAction<int, float> OnCustomEvent;
// 3 Parameters
public event UnityAction<int, float, bool> OnCustomEvent;
// 4 Parameters
public event UnityAction<int, float, bool, string> OnCustomEvent;

```

## Rigidbody 2D


## Various audio examples for Unity
```c#
using UnityEngine;
using System.Collections;

public class AudioExamples : MonoBehaviour
{
    // Important: You need to have an AudioSource component attached to this gameObject
    private AudioSource audioSource;

    // Set an audioclip in the Inspector
    public AudioClip clip1;

    void Start()
    {
        // Get the AudioSource component
        audioSource = GetComponent<AudioSource>();

        // Plays the AudioClip set in the AudioSource component. Will be interrupted if the function is called again.
        audioSource.Play();
    }

    void Update()
    {
        // AudioSource.Play() can also be paused or stopped. 
        // Check if audioSource is playing a clip. Jump is space and Fire1 is left ctrl.
        if (audioSource.isPlaying)
        {
            if (Input.GetButtonDown("Jump"))
            {
                audioSource.Pause();
            }
            else if (Input.GetButtonDown("Fire1"))
            {
                audioSource.Stop();
            }
        }

        // PlayOneShot can be used to play a short clip. Will not be interrupted if the function is called again. 
        // Can't be used with Pause & Stop. Fire2 is left alt in the Input Manager.
        if (Input.GetButtonDown("Fire2"))
        {
            audioSource.PlayOneShot(clip1);

            // You can give this an optional volume setting as well (0-1 range)
            //audioSource.PlayOneShot(clip1, 0.5f);
        }

        // Fire3 is left shift
        if (Input.GetButtonDown("Fire3"))
        {
            // Set the pitch and volume of the clips played by Audio Source. Volume range is 0~1
            audioSource.pitch = Random.Range(0.25f, 2f);

            audioSource.volume = Random.Range(0.25f, 1f);
        }
    }
}

Sert cisimler, yerçekimine, kütleye, sürüklenmeye ve momentuma tepkiler gibi fizik temelli davranışları mümkün kılar.

```

## Various UI examples for Unity 5+

```c#
using UnityEngine;
using System.Collections;
// Needed fro UI in Unity 5+
using UnityEngine.UI;

public class UIExamples : MonoBehaviour
{
    // Set the target UI Text in the Inspector
    public Text uiText;

    // Set the target UI image in Inspector. UI Image must be "filled" type
    public Image uiImage;

    private int uiNumber = 7;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            // Basic usage
            uiText.text = "HELLO";

            // Fill amount is in a range from 0-1. Empty
            uiImage.fillAmount = 0;
        }
        else if (Input.GetButtonDown("Fire1"))
        {
            // Numbers must be converted to strings
            uiText.text = uiNumber.ToString();
            
            // Larger ranges of number can be converted by dividing with the max value. Halfway
            uiImage.fillAmount = 3.5f/uiNumber;
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            // Numbers can be formatted to display a certain number of places
            uiText.text = uiNumber.ToString("000");

            // Full
            uiImage.fillAmount = 1;
        }
    }
}
```

