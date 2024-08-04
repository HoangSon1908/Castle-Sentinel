using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;

public class chỉ_số_người_chơi : MonoBehaviour
{
    public static int tinh_thể;//có thể truy cập thông qua tên lớp mà không cần tạo ra các thể hiện cụ thể của lớp.
    public int tinh_thể_khởi_đầu = 200;

    private static int _mạng;
    // ENCAPSULATION
    public static int mạng
    {
        get { return _mạng; }
        set
        {
            // Đảm bảo giá trị của mạng không bao giờ dưới 0
            if (value < 0)
            {
                _mạng = 0;
            }
            else
            {
                _mạng = value;
            }
        }
    }

    public int mạng_khởi_đầu = 10;
    public static int lượt;
    public static int số_trụ_súng;

    private void Start()
    {
        tinh_thể = tinh_thể_khởi_đầu;
        mạng = mạng_khởi_đầu;
        lượt = 0;
        số_trụ_súng = 0;
    }

    public Text Mạng;
    public Text tiền;
    public Text trụ_súng;

    private void Update()
    {
        Mạng.text = chỉ_số_người_chơi.mạng + " Life";
        tiền.text ="$" + tinh_thể;
        trụ_súng.text = số_trụ_súng + "/10";
    }
}
