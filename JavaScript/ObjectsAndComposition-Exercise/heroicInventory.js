function heroicInventory(input) {
    let result = [];

    for (const line of input) {
        let[name,level,items] = line.split(' / ');
        level =Number(level);
        items = items?items.split(', '):[];
        result.push({name,level,items});
    }    

    console.log(JSON.stringify(result));
}

heroicInventory(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara'])