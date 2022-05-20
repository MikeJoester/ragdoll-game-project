using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    [Header("Item View")]
    public Image itemView;
    public TextMeshProUGUI desc;

    [Header("List Items")]
    public Sprite[] itemList;
    public string[] descriptions;

    public void Item1() {
        itemView.sprite = itemList[0];
        desc.text = "Một con búp bê có dính máu. Không biết điều này có liên quan gì đến Chi không nhỉ?";
    }
    public void Item2() {
        itemView.sprite = itemList[1];
        desc.text = "Quần áo của Chi được tìm thấy trong phòng anh Minh. Thật là khả nghi...";
    }
    public void Item3() {
        itemView.sprite = itemList[2];
        desc.text = "Một nắm tóc trong phòng của Chi, có điều gì đó bạo lực xảy ra chăng?";;
    }
    public void Item4() {
        itemView.sprite = itemList[3];
        desc.text = "Là cặp của bố của Chi. Ở trong đấy có một chiếc áo của Chi. Không biết ông ta có điều gì mờ ám không...";
    }
    public void Item5() {
        itemView.sprite = itemList[4];
        desc.text = "Nhật kí của Chi. Trong đó ghi lại những điều xảy ra trong những ngày vừa qua.";
    }
    public void Item6() {
        itemView.sprite = itemList[5];
        desc.text = "Đây là vật dụng cá nhân của Chi phải không nhỉ? Tại sao nó lại xuất hiện trong phòng của anh Minh?";
    }
    public void Item7() {
        itemView.sprite = itemList[6];
        desc.text = "Một chiếc áo xanh. Cỡ áo này quá rộng để là áo của Chi.";
    }
    public void Item8() {
        itemView.sprite = itemList[7];
        desc.text = "Một chiếc đai võ trong phòng Chi. Chẳng lẽ Chi là một cao thủ võ lâm giấu mặt ư?";
    }
    public void Item9() {
        itemView.sprite = itemList[8];
        desc.text = "Một chiếc điện thoại cũ ở trong hộc bàn anh Minh. Ảnh gì thế này? Đây có phải là Chi không??";
    }
}
