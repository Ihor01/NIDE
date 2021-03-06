﻿ItemsEngine = {};

ItemsEngine.SetItemFromJson = function(name){
    var str    = ModPE.openInputStreamFromTexturePack("items//" + name);
    var string = Util.convertStreamToString(str);
    var json   = JSON.parse(string);
    if (json.type == "item"){
        ModPE.setItem(json.id, json.texture.name, json.texture.meta, json.name, json.maxStack);
    }
    else if (json.type == "block")
    {
        Block.defineBlock(json.id, json.name, [[json.texture.name, json.texture.meta]], json.material, json.opaque, json.renderType);
        Block.setDestroyTime(json.id, json.destroyTime);
        Block.setExplosionResistance(json.id, json.explosionResistance);
    }
    else if (json.type == "food")
        ModPE.setFoodItem(json.id, json.texture.name, json.texture.meta, json.restore, json.name, json.maxStack);
    else if (json.type == "armor")
        Item.defineArmor(json.id, json.texture.name, json.texture.meta, json.name, json.armorTexture, json.reduceDamage, json.maxDamage, json.armorType);
    else if (json.type == "throwable")
        Item.defineThrowable(json.id, json.texture.name, json.texture.meta, json.name, json.maxStack);
}