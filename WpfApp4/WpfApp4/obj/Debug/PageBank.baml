   M S B A M L   `   `   `  ����B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp4WpfApp4  5   	       WpfApp4.PageBank   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp4     5   	     � Title$  
Карта��5   	   $	��300��6   $	��350��6$    � WindowStartupLocation$ CenterScreen=�60   .��5	      � $	��300��6   $	��350��6   ��5
   
   �� 5       �� Color$ Black��6    �� Opacity$
 0.23Q�6,   .+�5   
   �� $��Оплата картой��6   $��Center=�6)   $��0 10 0 0q�6F   $��DemiBold"�6X   $��20(�6n   �� 5   
   $��Номер карты��6   $
��Left=�6'   $��13(�6B   $��	20 35 0 0q�6P   �� 5   
   -   5         ��Name$ number��5      $	��300��6"   $��20��6.    �� 	MaxLength$ 16��6:   $
��Left=�6I   $��
20 0 0 135q�6d    �� TextAlignment$ Center=�6x   6�   �� 5   
   $��Срок годность��6   $
��Left=�6)   $��13(�6D   $��
20 100 0 0q�6R   �� 5   
   -   5        $
 date��5      $��55��6    $��25��6+   $ 4��67   $
��Left=�6E   $��20 0 0 0q�6`   $ Center=�6r   6�   �� 5   
   $��
Cvv код��6   $
��Left=�6#   $��13(�6>   $��144 100 0 0q�6L   �� 5   
   -   5        $	 cvv��5      $��55��6   $��25��6*   $ 3��66   $
��Left=�6D   $��	144 0 0 0q�6_   $ Center=�6r   6�   �� 5   
   -   5        $��Оплатить��5      $
��Bold"�6$   $��10(�66   
���   �
�������$��30��6k   $��85��6z   $��2��6�   $��	0 120 0 0q�6�    � 	Resources 5       �� 
TargetType	 �� Property
 �� Value��%_   '��       �� 5      " ��6   .�5      �� 	 �@��CornerRadius$
 12��65   5      5      5      5      5      