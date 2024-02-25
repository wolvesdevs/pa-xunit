using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using ZZZ.Domain.Exceptions;
using ZZZ.Domain.Helper;
using ZZZ.UI.ViewModels;

namespace ZZZ.Tests;

public class UnitTest1
{
    [Fact]
    public void �ŏ��̃e�X�g_����()
    {
        int value = 123;
        Assert.Equal(123, value);

        //string stringValue = "abc";
        //stringValue.Is("abc");
    }

    [Fact]
    public void bool�̃e�X�g()
    {
        var vm = new ProductViewModel();
        //vm.IsChecked.IsTrue();
        //vm.IsReadOnly.IsFalse();
    }

    [Fact]
    public void �����̃e�X�g()
    {
        ProductViewModel vm = new();
        vm.Price = 123;
        //vm.PriceText.Is("123�~");

        Assert.StartsWith("Ab", "Abc123");
        Assert.EndsWith("23", "Abc123");
        Assert.Equal("Abc123", "AbC123", ignoreCase: true);
        Assert.Contains("c1", "Abc123");
    }

    [Fact]
    public void ���K�\���̃e�X�g()
    {
        Assert.DoesNotMatch("^[0-9]+$", "123A45");
        Assert.Matches("^[0-9]+$", "12345");

        Assert.DoesNotMatch("^[A-Za-z]+$", "ABC1");
        Assert.Matches("^[A-Za-z]+$", "Abc");
    }

    [Fact]
    public void ���l�̃e�X�g()
    {
        ProductViewModel vm = new();
        vm.Price = 123;
        Assert.Equal(123, vm.Price);
        Assert.NotEqual(555, vm.Price);

        Assert.InRange(vm.Price, 123, 200);
        Assert.NotInRange(vm.Price, 124, 200);
    }

    [Fact]
    public void ���������_���̃e�X�g()
    {
        ProductViewModel vm = new();
        var result = vm.Divide(100, 3);
        Assert.Equal(33.333333333333336, result);
        Assert.Equal(33.3333, result, 4);

        double d1 = 1.23442;
        Assert.Equal(1.2344, d1, 4);
    }

    [Fact]
    public void Null�̃e�X�g()
    {
        ProductViewModel vm = new();
        Assert.Null(vm.Product);
        vm.CreateProduct();
        Assert.NotNull(vm.Product);
    }

    [Fact]
    public void �R���N�V�����̃e�X�g_All()
    {
        List<string> items = ["AAA", "BBB", "CCC"];
        Assert.All(items, item => Assert.True(item.Length == 3));
    }

    [Fact]
    public void �R���N�V�����̃e�X�g_Single()
    {
        List<int> items1 = [3];
        Assert.Single(items1);

        List<int> items2 = [1, 1, 2, 3, 3];
        Assert.Single(items2, item => item == 2);
        Assert.Single(items2, 2);
    }

    [Fact]
    public void �R���N�V�����̃e�X�g_Collection()
    {
        List<string> items = ["AAA", "BB", "C"];
        Assert.Collection(items,
            item => Assert.True(item.Length == 3),
            item => Assert.True(item.Length == 2),
            item => Assert.True(item.Length == 1)
            );
    }

    [Fact]
    public void �R���N�V�����̃e�X�g_Contains_�v���~�e�B�u�^()
    {
        List<int> items = [111, 123, 333];
        Assert.Contains(123, items);
        Assert.DoesNotContain(12, items);
    }

    [Fact]
    public void �R���N�V�����̃e�X�g_Contains_�Q�ƌ^()
    {
        List<ProductId> items = [new(1), new(2), new(3)];
        Assert.Contains(new(2), items);

        List<string> strings = ["AAA", "BBB", "CCC"];
        Assert.Contains("BBB", strings);
    }

    [Fact]
    public void �R���N�V�����̃e�X�g_Equal()
    {
        List<string> listA = ["AAA", "BBB", "CCC"];
        List<string> listB = ["AAA", "BBB", "CCC"];

        Assert.Equal(listA, listB);

        List<ProductId> productIdsA = [new(1), new(2), new(3)];
        List<ProductId> productIdsB = [new(1), new(2), new(3)];

        Assert.Equal(productIdsA, productIdsB);
    }

    [Fact]
    public void Dictionary�̃e�X�g()
    {
        Dictionary<ProductId, string> dic1 = new()
        {
            { new(1), "AAA" },
            { new(2), "BBB" },
            { new(3), "CCC" }
        };

        Assert.Equal("BBB", dic1[new(2)]);

        Dictionary<ProductId, string> dic2 = new()
        {
            { new(1), "AAA" },
            { new(2), "BBB" },
            { new(3), "CCC" }
        };

        Assert.Equal(dic1, dic2);

    }

    [Fact]
    public void ����C���X�^���X�̃e�X�g_Same()
    {
        ProductId p1 = new(1);
        ProductId p2 = new(1);

        Assert.Equal(p1, p2);
        //Assert.Same(p1, p2);
        Assert.NotSame(p1, p2);
    }

    [Fact]
    public void �I�u�W�F�N�g�^�C�v�̃e�X�g_IsType()
    {
        int a = 1;
        Assert.IsType<int>(a);

        string b = "";
        Assert.IsType<string>(b);

        ProductId c = new(1);
        Assert.IsType<int>(c.Value);

        MemberBase member = MemberBase.Create(1);
        Assert.IsType<SilverMember>(member);
        Assert.IsNotType<GoldMember>(member);

        var silver = Assert.IsType<SilverMember>(member);
        Assert.Equal("Silver", silver.Value);
    }

    [Fact]
    public void �I�u�W�F�N�g�^�C�v�̃e�X�g_IsAssignableFrom()
    {
        SilverMember silver = new();
        Assert.IsAssignableFrom<MemberBase>(silver);

        Form form = new();
        Assert.IsAssignableFrom<Control>(form);
        Assert.IsAssignableFrom<ContainerControl>(form);
        Assert.IsAssignableFrom<IContainerControl>(form);
        Assert.IsAssignableFrom<IDisposable>(form);
    }

    [Fact]
    public void ��O�̃e�X�g()
    {
        ProductViewModel vm = new();
        string value = null;
        var ex = Assert.Throws<SaveException>(() => vm.Save(value));
        Assert.Equal("value��NULL�ł�", ex.Message);
    }

    [Fact]
    public void �C�x���g�̒ʒm�e�X�g()
    {
        ProductViewModel vm = new();
        Assert.Raises<int>(
            h => vm.PriceChanged += h,
            h => vm.PriceChanged -= h,
            () => vm.ChangePrice(123)
            );

    }

}