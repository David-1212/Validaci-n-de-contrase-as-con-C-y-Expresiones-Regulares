# Validador de Contraseñas en C#

## Descripción
Este proyecto en **C# (Windows Forms)** permite verificar si una contraseña cumple con los requisitos mínimos de seguridad y si coincide con su confirmación.  

---

## Requisitos de seguridad
Para que una contraseña sea válida, debe cumplir con **todos** los siguientes criterios:

- Contener al menos **una letra mayúscula**.  
- Contener al menos **una letra minúscula**.  
- Contener al menos **un número**.  
- Contener al menos **un carácter especial** (`@`, `#`, `$`, `%`, `!`, `?`, `*`, etc.).  
- Coincidir exactamente con la **contraseña de confirmación**.

---

## Cómo funciona

El programa solicita dos entradas:

1. La **contraseña**.  
2. La **confirmación** de la contraseña.

Luego realiza validaciones para verificar que:

- Ambas contraseñas sean idénticas.  
<img width="805" height="488" alt="no coinciden entre si" src="https://github.com/user-attachments/assets/82563a1f-6ee2-4bd6-aca0-039b528498c3" />

-La contraseña no contiene todos los caracteres esperados.
<img width="793" height="482" alt="caracteres no esperados" src="https://github.com/user-attachments/assets/50081be6-78b4-4626-beaf-1110e188e6f1" />

- La contraseña cumpla con todos los criterios de seguridad.  
<img width="801" height="481" alt="contraseña valida" src="https://github.com/user-attachments/assets/c7b09524-5509-47ad-88fd-ba0a5300bd74" />





---

## Tecnologías
- **Lenguaje:** C#  
- **Plataforma:** Windows Forms  
- **Validación:** Expresiones regulares (Regex)  

---

