   M S B A M L   `   `   `  ����S  OCadastroResponsavelAluno, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:CadastroResponsavelAluno.GestorCadastroResponsavelAluno.Gestor  5   	   8    2CadastroResponsavelAluno.Gestor.WindowAlterarAluno   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:CadastroResponsavelAluno.Gestor     5   	     � Title$  WindowAlterarAluno��5   	   $	��400��5	   	   $	��400��5
   	   
������  � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . .��5      �� ���#FFFFFF$	��350��6"   $	��350��6/    �� CornerRadius$ 5��6;    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ #000000��6      ShadowDepth$ 0Q�6/      Opacity$	 0.8Q�6?   	   
BlurRadius$	 20Q�6M   ._�5   
   �� $��Center=�6   $��Center=�60   .+�5      �� $��Alterar dados do aluno��6   $��20(�65   $
��Bold"�6C   �� 5         LabelCadastroAluno#��[  6   $��Nome do aluno��6@   �� 5      -   5        
 ��Name$
 
CampoAluno��5        CampoCadastroAluno#��[ 6*   �� 5      #��[  6   $��Turma��6@   �� 5      -   5         ��Name$ ComboBoxTurma��5      $	��100��6.   $��30��6:   $
��Left=�6F   $��Center=�6a   $��16(�6�   �� 5      #��[  6   $��Nome do responsável��6@   �� 5      -   5        $
 CampoResponsavel��5      #��[ 60   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ BotaoVoltar��5        BotaoCadastroAluno#��[ 6.   $��Voltar��6Z   $��Bottom=�6k   $��0, 0, 20, 0q�6�   6�   �� 5       -   5        $ BotaoAlterarAluno��5       #��[ 64   $��Alterar��6`   6r   5!      5"      5#      5$      