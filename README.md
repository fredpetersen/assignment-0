# assignment-0

Assignment created as part of Analysis, Design and Software architecture, on 3rd semester of the Software development bachelor, at ITU

Further documentation found in `docs/report.pdf`

Report made in LaTeX with Overleaf.[LaTeX source found here](https://www.overleaf.com/read/kzphzfhfqbsh)

## Flowchart

```mermaid
    flowchart TD
    D[IsLeapYear?] -- int --> E{Year earlier than 1582?}
    E -- yes --> F[return false]
    E -- no --> G{year divisible by 400?}
    G -- yes --> H[return true]
    G -- no --> I{year divisible by 100?}
    I -- yes --> F
    I -- no --> J{Year divisible by 4?}
    J -- yes --> H
    J -- no --> F
```
