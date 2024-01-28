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

Awake()- Bu işlev, bir oyun nesnesi başlatıldıktan sonra çağrılır.
OnEnable()- Bu işlev, bir oyun nesnesi etkinleştirildiğinde çağrılır.
Start()- Bu fonksiyon ilk çerçeve güncellemesinden önce çağrılır.
Update()- Bu fonksiyon her karede çağrılır.
LateUpdate()- Bu fonksiyon, fonksiyon çağrıldıktan sonraki her karede çağrılır .Update()
OnBecameVisible()- Bu işlev, geçerli oyun nesnesi herhangi bir kamera aracılığıyla görünür hale geldiğinde çağrılır.
OnBecameInvisible()- Bu işlev, mevcut oyun nesnesi artık herhangi bir kamera tarafından görülemediğinde çağrılır.
OnDrawGizmos()- Bu işlev, sahne penceresinde aygıtların çizilmesi için çağrılır .
OnGUI()- Bu işlev GUI olayları için birden çok kez çağrılır.
OnApplicationPause()- Bu işlev, oyun Unity editörü aracılığıyla duraklatıldığında çağrılır.
OnDisable()- Bu işlev oyun nesnesi devre dışı bırakıldığında çağrılır.
OnDestroy()- Bu işlev, oyun nesnesi yok edildiğinde çağrılır.
FixedUpdateSaniyede sabit sayıda kez olarak adlandırılan, adında bir yaşam döngüsü işlevi vardır . Frekansı Düzenle ▸ Proje Ayarları ▸ Zaman ▸ Sabit Zaman Adımı'nda yapılandırabilirsiniz .
